package HelloWorld.Tests;

import static org.junit.Assert.*;
import org.junit.Test;

public class HelloTests {

	@Test
	public void firstPassingTest() {
		assertTrue(true);
	}
	
	@Test
	public void firstFailingTest() {
		fail("This must fail!!");
	}

}
