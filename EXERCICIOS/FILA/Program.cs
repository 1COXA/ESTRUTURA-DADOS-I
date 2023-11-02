using QueueClass;

Queue fila = new();

fila.Enqueue(14);
fila.Enqueue(31);
fila.Enqueue(22);
fila.Enqueue(1);
fila.Enqueue(12);
fila.Print();
fila.PeekEnd();
fila.PeekStart();

int comprimento = fila.Length();
Console.WriteLine($"O tamanho da fila é: {comprimento}");
