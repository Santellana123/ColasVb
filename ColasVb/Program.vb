Imports System

Module Program
    Sub Main(args As String())
        Dim miCola As New Queue()
        Dim a As Integer = 1

        Do
            Console.WriteLine("Seleccione una operaci�n:")
            Console.WriteLine("1. Agregar elemento a la cola")
            Console.WriteLine("2. Eliminar elemento de la cola")
            Console.WriteLine("3. Imprimir la cola")
            Console.WriteLine("4. Salir")

            Dim opcion As Integer
            If Integer.TryParse(Console.ReadLine(), opcion) Then
                Console.Clear()
                Select Case opcion
                    Case 1
                        Console.Write("Ingrese el elemento a agregar: ")
                        Dim entrada As String = Console.ReadLine()
                        Dim elementoAgregar As Integer

                        If Integer.TryParse(entrada, elementoAgregar) Then
                            EnqueueElemento(miCola, elementoAgregar)
                        Else
                            Console.WriteLine("Por favor, ingrese un valor entero v�lido.")
                        End If
                    Case 2
                        DequeueElemento(miCola)
                    Case 3
                        ImprimirCola(miCola)
                    Case 4
                        Console.WriteLine("Saliendo del programa.")
                        a = 2
                    Case Else
                        Console.WriteLine("Opci�n no v�lida. Intente nuevamente.")
                End Select
            Else
                Console.WriteLine("Por favor, ingrese un n�mero v�lido.")
            End If

        Loop While a = 1
    End Sub

    ' M�todo para insertar elementos en la cola
    Sub EnqueueElemento(cola As Queue, elemento As Integer)
        cola.Enqueue(elemento)
        Console.WriteLine($"Se agreg� el elemento {elemento} a la cola.")
    End Sub

    ' M�todo para eliminar un elemento de la cola
    Sub DequeueElemento(cola As Queue)
        If cola.Count > 0 Then
            Dim elementoEliminado As Integer = DirectCast(cola.Dequeue(), Integer)
            Console.WriteLine($"Se elimin� el elemento {elementoEliminado} de la cola.")
        Else
            Console.WriteLine("La cola est� vac�a. No se puede eliminar ning�n elemento.")
        End If
    End Sub

    ' M�todo para imprimir la cola
    Sub ImprimirCola(cola As Queue)
        Console.Write("Contenido de la cola: ")
        For Each elemento In cola
            Console.Write(elemento & " ")
        Next
        Console.WriteLine()
    End Sub

End Module
