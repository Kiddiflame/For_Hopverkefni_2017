using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Hopverkefni_2017
{
    class BtTree
    {
        BtNode rootNode;
        public BtTree(string question, string yesGuess, string noGuess)
        {
            rootNode = new BtNode(question);
            rootNode.setYesNode(new BtNode(yesGuess));
            rootNode.setNoNode(new BtNode(noGuess));
        }
        public void query()
        {
            rootNode.query();
        }
    }
}
