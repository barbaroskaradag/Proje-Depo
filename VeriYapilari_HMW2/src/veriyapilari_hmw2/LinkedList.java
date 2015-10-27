
package veriyapilari_hmw2;

public class LinkedList<T> {
    
    Node head = null;
    
    public void elemanEkle(T data)
    {
        if(head == null)
        {
            head = new Node();
            head.data = data;
            head.next = null;
        }
        else
        {
            Node newNode= new Node();
            newNode.data= data;
            newNode.next= null;
            Node temp = head;
            while(temp.next!= null)
            {
                temp = temp.next;
            }
            temp.next= newNode;
        }
    }
    
       
    public void deleteNode(int index)
    {
        Node current= head;
        Node tmp= null;
        int count = 0;
        
        if(count == index)
        {
            tmp= current.next;
            head= tmp;
        }
        else
        {
            while(current.next!= null)
            {
                count++;
                if(count == index)
                {
                    tmp= current.next;
                    current.next= tmp.next;
                    break;
                }
                current= current.next;
            }
        }

    }

}
