# Challenges-CSharp
___________
### Morse Code Translator
Background
You've started work as morse code translator. Unfortunately some of the signals aren't as distinguishable as others and there are times where a . seems indistinguishable from -. In these cases you write down a ? so that you can figure out what all the posibilities of that letter for that word are later.

Task
Write a function possibilities that will take a string signals and return an array of possible characters that the Morse code signals could represent.

![image](https://user-images.githubusercontent.com/47873305/156679141-e70709c4-2a3c-4adf-bf37-59538966ebed.png)

Specification
Challenge.Possibilities(signals)
Parameters
signals: string - The Morse code signals that needs to be parsed. The may contain one or more unknown signals (?).

Return Value
List<string> - The list of possible letters for the given group of signals. Letters will always be ordered from how they appear on the chart, from left to right.

Constraints
There will be no more than 3 characters within signals.

0 - 3 unknown signals may be given.
____________
### Sort CSV Table  
Write a method that sorts the columns by the names of the columns alphabetically, and case-insensitive.  
 
Original format: 
Beth,Charles,Danielle,Adam,Eric\n17945,10091,10088,3907,10132\n2,12,13,48,11
  
Final format:  
Adam,Beth,Charles,Danielle,Eric
17945,10091,10088,3907,10132
2,12,13,48,11
