import sys
import os
dirname = os.path.dirname
print(os.path.join( dirname(dirname(dirname(__file__))), 'py', 'py' + str(1) +'.png'))
import numpy as np
import matplotlib.pyplot as plt

class DataMatrix:
    n_metadata = 6
    letter_position = 1
    n_cols = 8
    n_rows = 16

    def __init__(self, input):
        self.data = np.zeros((self.n_rows, self.n_cols))

        #data preprocessing
        #formatted_input = "".join(input.split('\t'))
        formatted_input = input.split('\t')
        self.letter = formatted_input[self.letter_position]
        #Using a row of the input file as an input, we'll put the data in a
        #numpy matrix
        for y in range(0, self.n_rows):
            for x in range(0, self.n_cols):
                self.data[y, x] = formatted_input[self.n_metadata + (self.n_cols * y) + x]



class DataSet:
    def __init__(self, input_file):
        #Creating the data frame
        self.dataFrame = []
        #Opening data file
        f = open(input_file, 'r')
        n_lines = len(f.readlines())
        
        #Returning at the beginning of the file
        f.seek(0)
        for i in range(n_lines):
            self.dataFrame.append(DataMatrix(f.readline()))
            plt.imshow(self.dataFrame[i].data)
            plt.savefig(os.path.join( dirname(dirname(dirname(__file__))), 'py', 'py' + str(i) +'.png'))
        f.close()

filename = 'letter.data'
path = 'OCR/data'

dataset = DataSet(os.path.join(path, filename))
#plt.plot(dataset.dataFrame[0])
#for i in range(0, 9):
 #   plt.imshow(dataset.dataFrame[i].data)
  #  plt.savefig(os.path.join( dirname(dirname(dirname(__file__))), 'py', 'py' + str(i) +'.png'))