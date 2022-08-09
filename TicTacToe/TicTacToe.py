board = {1: ' ', 2: ' ', 3: ' ',
         4: ' ', 5: ' ', 6: ' ',
         7: ' ', 8: ' ', 9: ' '}
player = 'O'
computer = 'X'

def BordDraw(board):
    print(board[1] + "|" + board[2] + "|" + board[3])
    print("-+-+-")
    print(board[4] + "|" + board[5] + "|" + board[6])
    print("-+-+-")
    print(board[7] + "|" + board[8] + "|" + board[9])
    print("\n")

def SpaceIsFree(position):
    if board[position] == ' ':
        return True 
    return False 

def Insert(letter, position):
    if SpaceIsFree(position):
        board[position] = letter 
        BordDraw(board)
        if checkDraw():
            print("Draw!")
            exit() 
        if checkWin():
            if letter == '0':
                print("Artho wins!")
                exit()
            else:
                print("Anik wins!")
                exit()
        return 
    else:
        print("Invalid position")
        position = int(input("Please enter a new position: "))
        Insert(letter, position)
        return    

def checkWin():
    if (board[1] == board[2] and board[1] == board[3] and board[1] != ' '): 
        return True
    elif (board[4] == board[5] and board[4] == board[6] and board[4] != ' '):
        return True
    elif (board[7] == board[8] and board[7] == board[9] and board[7] != ' '):
        return True
    elif (board[1] == board[4] and board[1] == board[7] and board[1] != ' '):
        return True
    elif (board[2] == board[5] and board[2] == board[8] and board[2] != ' '):
        return True
    elif (board[3] == board[6] and board[3] == board[9] and board[3] != ' '):
        return True
    elif (board[1] == board[5] and board[1] == board[9] and board[1] != ' '):
        return True
    elif (board[7] == board[5] and board[7] == board[3] and board[7] != ' '):
        return True
    else:
        return False



def checkDraw():
    for i in board.keys():
        if board[i] == ' ':
            return False 
    return True 

def playerMove():
    position = int(input("Enter a position for 'O': "))
    Insert(player, position)
    return 

def compMove():
    position = int(input("Enter a position for 'X': "))
    Insert(computer, position)
    return 

  


while not checkWin():
    playerMove()
    compMove()
   
