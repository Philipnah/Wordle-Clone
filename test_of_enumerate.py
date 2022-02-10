import random
import time

AllWordsFile = "AcceptableWordlist.txt"
AnswerWordsFile = "AnswerWordlist.txt" 

def FindNewWord():
	i = 0
	with open(AllWordsFile, 'r') as wordlist:
		for line in wordlist:
			i += 1
	
	return i
		

def EnumerateWords():
	with open(AllWordsFile, 'r') as fp:
		for count, line in enumerate(fp):
			pass

	return count + 1


start = time.time()
# print(FindNewWord())
print(EnumerateWords())
end = time.time()
print("Time consumed in working: ", end - start)