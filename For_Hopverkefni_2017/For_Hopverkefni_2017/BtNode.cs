using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Hopverkefni_2017
{
    class BtNode
    {
        string message;
        BtNode noNode;
        BtNode yesNode;
        /**
         * Constructor for the nodes: This class holds an String representing 
         * an object if the noNode and yesNode are null and a question if the
         * yesNode and noNode point to a BTNode.
         */
        public BtNode(string nodeMessage)
        {
            message = nodeMessage;
            noNode = null;
            yesNode = null;
        }
        public void query()
        {
            if (this.isQuestion())
            {
                Console.WriteLine(this.message);
                Console.Write("Enter 'y' for yes and 'n' for no: ");
                char input = getYesOrNo(); //y or n
                if (input == 'y')
                    yesNode.query();
                else
                    noNode.query();
            }
            else
                this.onQueryObject();
        }
        public void onQueryObject()
        {
            Console.WriteLine("Are you thinking of a(n) " + this.message + "?");
            Console.Write("Enter 'y' for yes and 'n' for no: ");
            char input = getYesOrNo(); //y or n
            if (input == 'y')
                Console.Write("The Computer Wins\n");
            else
                updateTree();
        }
        private void updateTree()
        {
            Console.Write("You win! What were you thinking of?");
            string userObject = Console.ReadLine();
            Console.Write("Please enter a question to distinguish a(n) "
                + this.message + " from " + userObject + ": ");
            string userQuestion = Console.ReadLine();
            Console.Write("If you were thinking of a(n) " + userObject
                + ", what would the answer to that question be?");
            char input = getYesOrNo(); //y or n
            if (input == 'y')
            {
                this.noNode = new BtNode(this.message);
                this.yesNode = new BtNode(userObject);
            }
            else
            {
                this.yesNode = new BtNode(this.message);
                this.noNode = new BtNode(userObject);
            }
            Console.Write("Thank you my knowledge has been increased");
            this.setMessage(userQuestion);
        }
        public bool isQuestion()
        {
            if (noNode == null && yesNode == null)
                return false;
            else
                return true;
        }
        /**
         * Asks a user for yes or no and keeps prompting them until the key
         * Y,y,N,or n is entered
         */
        private char getYesOrNo()
        {
            char inputCharacter = ' ';
            while (inputCharacter != 'y' && inputCharacter != 'n')
            {
                inputCharacter = Console.ReadLine().ElementAt(0);
                inputCharacter = Char.ToLower(inputCharacter);
            }
            return inputCharacter;
        }
        //Mutator Methods
        public void setMessage(string nodeMessage)
        {
            message = nodeMessage;
        }
        public string getMessage()
        {
            return message;
        }
        public void setNoNode(BtNode node)
        {
            noNode = node;
        }
        public BtNode getNoNode()
        {
            return noNode;
        }
        public void setYesNode(BtNode node)
        {
            yesNode = node;
        }
        public BtNode getYesNode()
        {
            return yesNode;
        }
    }
}
