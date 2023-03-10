using DeconstructionDeclaration;

var point = new Point(5, 8, 2);

//int x = 0;
int y = 0;
int z = 0;

// Объявление переменной в деконструкторе
(int x, y, z) = point;

