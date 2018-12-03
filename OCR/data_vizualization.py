import sys
print(sys.path)
import os

#import numpy as np
#import matplotlib.pyplot as plt

class DataMatrix:
    n_metadata = 6
    letter_position = 1
    n_cols = 8
    n_rows = 16

    def __init__(self, input):
        #self.data = np.zeros((self.n_rows, self.n_cols))

        #data preprocessing
        formatted_input = "".join(input.split('\t'))
        self.letter = formatted_input[self.letter_position]
        #Using a row of the input file as an input, we'll put the data in a
        #numpy matrix
        for y in range(0, self.n_rows):
            for x in range(0, self.n_cols):
                print()
                #data[y, x] = formatted_input[self.n_metadata + (self.n_cols * y) + x]



class DataSet:
    def __init__(self, input_file):
        #Creating the data frame
        self.dataFrame = []
        #Opening data file
        f = open(input_file, 'r')
        n_lines = count = len(f.readlines(  ))
        for i in range(0, 2):
            self.dataFrame.append(DataMatrix(f.readline()))

        f.close();

filename = 'letter.data'
path = 'OCR/data'
f=open(os.path.join(path, filename), 'r')
str = f.readline()
#str
formatted_input = "".join(str.split('\t'))
len(formatted_input)
letter = formatted_input[1]
letter
#formatted_input
f.close()

#os.listdir()


dataset = DataSet(os.path.join(path, filename))
dataset.dataFrame[0]
