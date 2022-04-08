from tkinter import Variable


class MyClass:
    Variable = "sepatu"
    def function(self):
        print("produk sepatu")
myobjectx = MyClass()
myobjecty = MyClass()
myobjecty.variable = " ini merupakan isi dari variable 2"
# Mencetak nilai dari 2 Variable dalam MyClass
print(myobjectx.Variable)
print(myobjecty.Variable)
#Aldeni marga putra