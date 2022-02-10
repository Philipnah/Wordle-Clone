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
				return line

	




FindNewWord(all_words_file)