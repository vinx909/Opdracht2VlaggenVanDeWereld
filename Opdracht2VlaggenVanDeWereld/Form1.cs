using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Opdracht2VlaggenVanDeWereld
{
    public partial class Form1 : Form
    {
        private List<Flag> flags;
        private List<Flag> testFlagOptions;
        private Flag testAnswer;
        private int testOptions=3;
        private Random random;
        private Stage stage;
        
        public Form1()
        {
            InitializeComponent();
            FlagsExist();
            DisableAll();
            SelectorStart(true);
        }

        private void DisableAll()
        {
            Controls.Remove(buttonSelectorView);
            Controls.Remove(buttonSelectorTest);
            Controls.Remove(buttonSelectorMenu);
            Controls.Remove(flagPicture);
            Controls.Remove(listBoxFlags);
        }

        private enum Stage
        {
            selector,
            viewer,
            tester
        }

        private void SetListBoxItems(List<Flag> items)
        {
            listBoxFlags.Items.Clear();
            foreach (Flag item in items)
            {
                listBoxFlags.Items.Add(item.getCountryName());
            }
        }

        private void FlagsExist()
        {
            if (flags == null)
            {
                flags = FlagGatherer.GatherAllFlags();
            }
        }

        private void SelectorStart()
        {
            SelectorStart(stage != Stage.selector);
        }
        private void SelectorStart(bool Allowed)
        {
            Controls.Add(buttonSelectorView);
            Controls.Add(buttonSelectorTest);
            stage = Stage.selector;
        }
        private void SelectorStop()
        {
            if (stage == Stage.selector)
            {
                Controls.Remove(buttonSelectorView);
                Controls.Remove(buttonSelectorTest);
            }
        }

        private void ViewerStart()
        {
            if (stage != Stage.viewer)
            {
                Controls.Add(listBoxFlags);
                Controls.Add(flagPicture);
                Controls.Add(buttonSelectorMenu);
                SetListBoxItems(flags);
                stage = Stage.viewer;
            }
        }
        private void ViewerStop()
        {
            if (stage == Stage.viewer)
            {
                Controls.Remove(listBoxFlags);
                Controls.Remove(flagPicture);
                Controls.Remove(buttonSelectorMenu);
            }
        }

        private void TestStart()
        {
            if (stage != Stage.tester)
            {
                Controls.Add(listBoxFlags);
                Controls.Add(flagPicture);
                Controls.Add(buttonSelectorMenu);
                TestSetup();
                stage = Stage.tester;
            }
        }
        private void TestStop()
        {
            if (stage == Stage.tester)
            {
                Controls.Remove(listBoxFlags);
                Controls.Remove(flagPicture);
                Controls.Remove(buttonSelectorMenu);
            }
        }

        
        private void SetFlagImage(Flag flag)
        {
            flagPicture.ImageLocation = flag.getFlagPicturePath();
        }

        private void TestSetup()
        {
            InitiateTestFlagOptions();
            for (int i=0;i< Math.Min(testOptions, flags.Count); i++)
            {
                Flag randomFlag = getRandomFlagFromFlagList(flags);
                while (FlagInFlagList(testFlagOptions, randomFlag))
                {
                    randomFlag = getRandomFlagFromFlagList(flags);
                }
                testFlagOptions.Add(randomFlag);
            }
            testAnswer = getRandomFlagFromFlagList(testFlagOptions);
            SetListBoxItems(testFlagOptions);
            SetFlagImage(testAnswer);
        }
        private void InitiateTestFlagOptions()
        {
            if (testFlagOptions == null)
            {
                testFlagOptions = new List<Flag>();
            }
            testFlagOptions.Clear();
        }
        private void InitiateRandom()
        {
            random = new Random();
        }
        private Flag getRandomFlagFromFlagList(List<Flag>list)
        {
            if (list.Count > 0)
            {
                InitiateRandom();
                return list[random.Next(list.Count)];
            }
            else
            {
                return null;
            }
        }
        private bool FlagInFlagList(List<Flag>list,Flag flag)
        {
            foreach(Flag listItem in list)
            {
                if (listItem == flag)
                {
                    return true;
                }
            }
            return false;
        }

        private void buttonSelectorView_Click(object sender, EventArgs e)
        {
            SelectorStop();
            ViewerStart();
        }

        private void buttonSelectorMenu_Click(object sender, EventArgs e)
        {
            if (stage == Stage.viewer)
            {
                ViewerStop();
            }
            else if (stage == Stage.tester)
            {
                TestStop();
            }
            SelectorStart();
        }

        private void listBoxFlags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stage == Stage.viewer)
            {
                string countryname = (string)listBoxFlags.SelectedItem;
                foreach (Flag flag in flags)
                {
                    string flagname = flag.getCountryName();
                    if (flagname.Equals(countryname))
                    {
                        SetFlagImage(flag);
                    }
                }
            }
            if (stage == Stage.tester)
            {
                string answerCountryname = (string)listBoxFlags.SelectedItem;
                if (answerCountryname.Equals(testAnswer.getCountryName()))
                {
                    MessageBox.Show("correct, this is the " + answerCountryname + " flag.");
                }
                else
                {
                    MessageBox.Show("incorrect, this is the " + testAnswer.getCountryName() + " flag.");
                }
                TestSetup();
            }
        }

        private void buttonSelectorTest_Click(object sender, EventArgs e)
        {
            SelectorStop();
            TestStart();
        }
    }
}
