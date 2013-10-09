
import org.apache.thrift.TException;
import org.apache.thrift.protocol.*;
import org.apache.thrift.transport.*;
import org.rfaisal.math.MathService;
public class MathClient {
	 public static void main(String[] args) throws TException{
		 TTransport transport = new TSocket("localhost", 9095);
		 transport.open();

		 TProtocol protocol = new  TBinaryProtocol(transport);
		 MathService.Client client = new MathService.Client(protocol);
		 client.add(10, 20);
	 }
}
