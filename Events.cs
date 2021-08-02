// An event is a notification sent by an object to signal the occurrence of an action.
// class who raises an event is publisher and who recieves it is subscriber. Basically it follows pub-sub model.

//Declaring the event
public delegate void Notify();  // delegate
                    
public class ProcessBusinessLogic
{
    public event Notify ProcessCompleted; // event

}
