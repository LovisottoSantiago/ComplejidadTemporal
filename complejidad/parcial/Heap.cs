
public class Heap{

    public void maxHeapify(int[] array, int tamaño, int index){

        var izq = 2 * index;
        var der = 2 * index + 1;
        var max = index;

        if (izq < tamaño && array[izq] > array[max]){
            max = izq;
        }
        if (der < tamaño && array[der] > array[max]){
            max = der;
        }

        if (max != index){
            // swap -- test
            int temp = array[index];
            array[index] = array[max];
            array[max] = temp;

            // recursión
            maxHeapify(array, tamaño, max);
        }

    }

}