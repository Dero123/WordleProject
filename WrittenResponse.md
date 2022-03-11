# Wordle Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

To challenge and entertain the user with a difficult word game 

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

The video demonstrates that my program can generate a random word, receive a user response, and color the user guess accordingly.

### 3a iii.

Describes the input and output of the program demonstrated in the video.

The user types in a word then the program returns the output that is the result of their guess in the terminal.

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
 List<string> correctWord = new List<string>();

            correctWord.Add("Anime");
            correctWord.Add("Manga");
            correctWord.Add("Frogs");
            correctWord.Add("Lemon");
            correctWord.Add("Shows");
            correctWord.Add("Phone");
            correctWord.Add("Soaps");
            correctWord.Add("Dance");
            correctWord.Add("Crabs");
            correctWord.Add("Again");
            correctWord.Add("Times");
            correctWord.Add("Crime");
            correctWord.Add("Finds");
            correctWord.Add("Lines");


```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
 Random Generator = new Random();
            int index = Generator.Next(0, correctWord.Count);

            string randomCorrectWord = correctWord[index];
            

            return randomCorrectWord.ToUpper();
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list stored in the variable {correctWord}

### 3b iv.

Describes what the data contained in the list represents in your program

The list contains all correct words that can be generated.

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

  The list manages complexity by using an index to create a variable, capable of storing the list in. If we did not use the list variable, we would need to write and 'if' statement for each possible correct word that can be generated.

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:


```csharp

```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp

```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

 

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.



## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.



### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 


Condition(s) tested by the second call:


### 3d iii.

Result of the first call:



Result of the second call:

