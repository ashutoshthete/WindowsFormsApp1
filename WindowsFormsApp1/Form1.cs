using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int CorrectAnswer;
        int Qnum = 1;
        int score;
        int percentage;
        int totalQuestion;




        public Form1()
        {
            InitializeComponent();
            askQuiestion(Qnum);
            totalQuestion = 10;
        }

       

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttontag = Convert.ToInt32(senderObject.Tag);
            if (buttontag == CorrectAnswer)
            {
                score++;
            }
            if (Qnum == totalQuestion)
            {
                percentage = (int)Math.Round((double)(score*100)/totalQuestion);
                MessageBox.Show(
                    "MCQ Test ended!"+Environment.NewLine+
                    "You have answered "+score+" questions correctly."+Environment.NewLine+
                    "Your total percentage is "+percentage+"%"+Environment.NewLine+
                    "click OK to play again"
                    );
                score = 0;
                Qnum = 0;
                askQuiestion(Qnum);
            }
            Qnum++;
            askQuiestion(Qnum);
        }
        private void askQuiestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    
                    lblQuistion.Text = "Number of primitive data types in java are?";
                    button1.Text = "6";
                    button2.Text = "7";
                    button3.Text = "8";
                    button4.Text = "9";

                    CorrectAnswer = 3;
                    break;

                case 2:
                    lblQuistion.Text = "Who invented Java Programming?";
                    button1.Text = "Guido van Rossum";
                    button2.Text = "James Gosling";
                    button3.Text = "Dennis Ritchie";
                    button4.Text = "Bjarne Stroustrup";

                    CorrectAnswer = 2;
                    break;
                case 3:
                    lblQuistion.Text = "Which component is used to compile, debug and execute the java programs?";
                    button1.Text = "JRE";
                    button2.Text = "JIT";
                    button3.Text = "JDK";
                    button4.Text = "JVM";

                    CorrectAnswer = 3;
                    break;
                case 4:
                    lblQuistion.Text = "Which one of the following is not a Java feature?";
                    button1.Text = "identifier & keyword";
                    button2.Text = "identifier";
                    button3.Text = "keyword";
                    button4.Text = "none of the mentioned";

                    CorrectAnswer = 3;
                    break;
                case 5:
                    lblQuistion.Text = "What is the extension of java code files??";
                    button1.Text = ".js";
                    button2.Text = ".txt";
                    button3.Text = ".class";
                    button4.Text = ".java";

                    CorrectAnswer = 4;
                    break;
                case 6:
                    lblQuistion.Text = "Which environment variable is used to set the java path??";
                    button1.Text = "MAVEN_Path";
                    button2.Text = "JavaPATH";
                    button3.Text = "JAVA";
                    button4.Text = "JAVA_HOME";

                    CorrectAnswer = 4;
                    break;
                case 7:
                    lblQuistion.Text = "Which of the following is not an OOPS concept in Java?";
                    button1.Text = "Polymorphism";
                    button2.Text = "Inheritance";
                    button3.Text = "Compilation";
                    button4.Text = "Encapsulation";

                    CorrectAnswer = 3;
                    break;
                case 8:
                    lblQuistion.Text = "Which of the following is a type of polymorphism in Java Programming?";
                    button1.Text = " Multiple polymorphism";
                    button2.Text = "Compile time polymorphism";
                    button3.Text = "Multilevel polymorphism";
                    button4.Text = "Execution time polymorphism";

                    CorrectAnswer = 2;
                    break;
                case 9:
                    lblQuistion.Text = "Which exception is thrown when java is out of memory?";
                    button1.Text = "MemoryError";
                    button2.Text = "OutOfMemoryError";
                    button3.Text = "MemoryOutOfBoundsException";
                    button4.Text = "MemoryFullException";

                    CorrectAnswer = 2;
                    break;
                case 10:
                    lblQuistion.Text = "Which of these are selection statements in Java?";
                    button1.Text = "break";
                    button2.Text = "continue";
                    button3.Text = "for()";
                    button4.Text = "if()";

                    CorrectAnswer = 4;
                    break;

            }
        }
    }
}
