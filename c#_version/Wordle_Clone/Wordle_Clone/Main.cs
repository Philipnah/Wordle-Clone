using System.Diagnostics;
using System.IO;

namespace Wordle_Clone {
	public partial class Main : Form {
		public Main() {
			InitializeComponent();
		}
		
		// full path to acceptable words list
		string all_words_file_path = @"C:\Users\phili\Desktop\Git\Wordle-Clone\AcceptableWordlist.txt";

		// full path to game words list
		string answer_words_file_path = @"C:\Users\phili\Desktop\Git\Wordle-Clone\AnswerWordlist.txt";

		char[] trimChars = { ' ', '\n' };

		string mysteryWord;
		string currentGuess;

		int guessesLeft = 6;

		private void Main_Load(object sender, EventArgs e) {
			// setup
			labelRespone.Text = "";
			labelGuessesLeft.Text = "Guesses Left: " + guessesLeft.ToString();

			mysteryWord = FindNewWord(answer_words_file_path);
#if DEBUG
			Debug.WriteLine(mysteryWord);
#endif

		}

		private bool IsWordValid(string guessedWord, string acceptedWordsPath) { // This word file path should be the accepted words list
			if (guessedWord == null) {
				return false;
			}

			if (guessedWord.Length != 5) {
				return false;
			}

			// iterates through list
			foreach (string line in File.ReadLines(acceptedWordsPath)) {
				if (guessedWord == line.Trim(trimChars)) {
					return true;
                }
			}

			return false;
        }

		private int WordsInList(string wordFilePath) {
			int counter = 0;

			// iterates through list
			foreach (string line in File.ReadLines(wordFilePath)) {
				counter++;
			}

			return counter;
		}

		private string FindNewWord(string wordFilePath) {
			int wordCount = WordsInList(answer_words_file_path);

			Random random = new Random();
			int randomLine = random.Next(0, wordCount);

			int counter = 0;

			// iterates through list
			foreach (string line in File.ReadLines(wordFilePath)) {
				if (counter == randomLine) {
					return line.Trim(trimChars);
				}

				counter++;
			}

			// if, for some reason, a string could not be found then this will be returned
			Debug.WriteLine("A new word could not be found!");
			return "a string could not be found for some reason";
		}

        private void buttonEnter_Click(object sender, EventArgs e) {
			if (IsWordValid(textBoxGuess.Text, all_words_file_path)) {
				currentGuess = textBoxGuess.Text;
				Debug.WriteLine("word is valid");
            } else {
				labelRespone.Text = "Word is invalid!";
				Debug.WriteLine("Word is invalid!");
				return;
            }

			if (currentGuess == mysteryWord) {
				labelRespone.Text = "You guessed the correct word!";
				Debug.WriteLine("You guessed the correct word!");
				textBoxGuess.Enabled = false;
				buttonEnter.Enabled = false;
			}


			// right letters are '1', wrong are '2' and correct placement is just the letter
			List<char> guessResponse = new List<char>();
            for (int i = 0; i < currentGuess.Length; i++) {
				if (mysteryWord.Contains(currentGuess[i])) {
					guessResponse.Add('1');
					// make correct letter buttons green
					switch (currentGuess[i].ToString().ToLower()) {
						case "a":
							buttonA.BackColor = Color.Green;
							break;
						case "b":
							buttonB.BackColor = Color.Green;
							break;
						case "c":
							buttonC.BackColor = Color.Green;
							break;
						case "d":
							buttonD.BackColor = Color.Green;
							break;
						case "e":
							buttonE.BackColor = Color.Green;
							break;
						case "f":
							buttonF.BackColor = Color.Green;
							break;
						case "g":
							buttonG.BackColor = Color.Green;
							break;
						case "h":
							buttonH.BackColor = Color.Green;
							break;
						case "i":
							buttonI.BackColor = Color.Green;
							break;
						case "j":
							buttonJ.BackColor = Color.Green;
							break;
						case "k":
							buttonK.BackColor = Color.Green;
							break;
						case "l":
							buttonL.BackColor = Color.Green;
							break;
						case "m":
							buttonM.BackColor = Color.Green;
							break;
						case "n":
							buttonN.BackColor = Color.Green;
							break;
						case "o":
							buttonO.BackColor = Color.Green;
							break;
						case "p":
							buttonP.BackColor = Color.Green;
							break;
						case "q":
							buttonQ.BackColor = Color.Green;
							break;
						case "r":
							buttonR.BackColor = Color.Green;
							break;
						case "s":
							buttonS.BackColor = Color.Green;
							break;
						case "t":
							buttonT.BackColor = Color.Green;
							break;
						case "u":
							buttonU.BackColor = Color.Green;
							break;
						case "v":
							buttonV.BackColor = Color.Green;
							break;
						case "w":
							buttonW.BackColor = Color.Green;
							break;
						case "x":
							buttonX.BackColor = Color.Green;
							break;
						case "y":
							buttonY.BackColor = Color.Green;
							break;
						case "z":
							buttonZ.BackColor = Color.Green;
							break;

						default:
							break;
					}
				} else {
					guessResponse.Add('2');
					// disable false letter buttons
                    switch (currentGuess[i].ToString().ToLower()) {
						case "a":
							buttonA.Enabled = false;
							break;
						case "b":
							buttonB.Enabled = false;
							break;
						case "c":
							buttonC.Enabled = false;
							break;
						case "d":
							buttonD.Enabled = false;
							break;
						case "e":
							buttonE.Enabled = false;
							break;
						case "f":
							buttonF.Enabled = false;
							break;
						case "g":
							buttonG.Enabled = false;
							break;
						case "h":
							buttonH.Enabled = false;
							break;
						case "i":
							buttonI.Enabled = false;
							break;
						case "j":
							buttonJ.Enabled = false;
							break;
						case "k":
							buttonK.Enabled = false;
							break;
						case "l":
							buttonL.Enabled = false;
							break;
						case "m":
							buttonM.Enabled = false;
							break;
						case "n":
							buttonN.Enabled = false;
							break;
						case "o":
							buttonO.Enabled = false;
							break;
						case "p":
							buttonP.Enabled = false;
							break;
						case "q":
							buttonQ.Enabled = false;
							break;
						case "r":
							buttonR.Enabled = false;
							break;
						case "s":
							buttonS.Enabled = false;
							break;
						case "t":
							buttonT.Enabled = false;
							break;
						case "u":
							buttonU.Enabled = false;
							break;
						case "v":
							buttonV.Enabled = false;
							break;
						case "w":
							buttonW.Enabled = false;
							break;
						case "x":
							buttonX.Enabled = false;
							break;
						case "y":
							buttonY.Enabled = false;
							break;
						case "z":
							buttonZ.Enabled = false;
							break;

						default:
                            break;
                    }
                }

				if (currentGuess[i] == mysteryWord[i]) {
					guessResponse[i] = currentGuess[i];
				}
            }

			// TODO: turn char list into guess, and put it in the listbox

			// converting char list to string
			string guessToAdd = "";
            foreach (char item in guessResponse) {
				guessToAdd = guessToAdd + item;
            }

			listBoxPreviousGuesses.Items.Add(guessToAdd + " : " + currentGuess);

			guessesLeft--;
			labelGuessesLeft.Text = "Guesses Left: " + guessesLeft.ToString();
			
			if (guessesLeft == -1) {
				labelRespone.Text = "You didn't guess the word";
				textBoxGuess.Enabled = false;
				buttonEnter.Enabled = false;
			}



			// At last remove the user input from the textbox
			textBoxGuess.Text = "";
		}

        private void buttonNewWord_Click(object sender, EventArgs e) {

        }
    }
}