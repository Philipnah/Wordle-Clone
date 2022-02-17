import random


all_words_file = "AcceptableWordlist.txt"
answer_words_file = "AnswerWordlist.txt" 

def WordsInList(listFile): # returns count of lines in listFile
	with open(listFile, 'r') as file:
		for count, line in enumerate(file):
			pass

	return count + 1


def FindNewWord(wordFile): # takes word file name, returns new word
	word_count = WordsInList(wordFile)
	randomLine = random.randint(0, word_count - 1)
	
	with open(wordFile, 'r') as wordlist:
		for count, line in enumerate(wordlist):
			if count == randomLine:
				return line.strip()

def Game():
	mysteryWord = FindNewWord(answer_words_file)

	# You have 6 guesses, so it loops 6 times
	n = 0
	guesses = 6

	# keep running as long as user has enough guesses left
	while n < guesses:

		userGuess = input("\nGuess: ")

		# Check if the user guess is a 5-letter word
		if len(userGuess) != 5:
			print("You need to guess a word that is 5 letters long")
			continue
		
		# Check if the user guess is valid, by opening the file and checking line by line. | TODO This could perhaps be improved, by loading the file into memory
		wordWasFound = False
		with open(all_words_file, "r") as file:
			for line in file:
				if line.strip() == userGuess:
					# the guess is valid
					wordWasFound = True
					break
			
		if wordWasFound == False:
			print("The guess is invalid. Try again.")
			continue



		answerToGuess = []

		# If the guess is correct, print congratulations
		if userGuess == mysteryWord:
			print("That is the correct word!\nCongratulations")
			return

		# go through the guess array and append the correct things
		for i in range(0, 5):
			if userGuess[i] in mysteryWord:
				answerToGuess.append("🟨")
			else:
				answerToGuess.append("⬛")

			# if the letter is in the correct spot, override the object at 'i' position with the correct letter
			if userGuess[i] == mysteryWord[i]:
				answerToGuess[i] = userGuess[i]
		

		print(str(answerToGuess) + "\nYou have " + str(guesses - (n + 1)) + " guesses left.")
		n += 1
	

	print("You did not guess the correct word!\nThe correct word was: " + str(mysteryWord) + "\n")
	return



# running the game
Game()