package HelloWorld.Tests;

import static org.junit.Assert.*;
import org.junit.Test;
import HelloWorld.WeatherService;
import static org.mockito.Mockito.*;

public class HelloTests {

	@Test
	public void firstPassingTest() {
		assertTrue(true);
	}
	
	//@Test
	//public void firstFailingTest() {
	//	fail("This must fail!!");
	//}
	
	@Test
	public void stubTestWithMockito()
    {
		//Arrange
		WeatherService service = mock(WeatherService.class);
		when(service.getWeather("Rome")).thenReturn("Sunny");
		when(service.getWeather("Cortina")).thenReturn("Snowy");
		
		//Act
		String actual = service.getWeather("Rome");
		
		//Assert
		assertEquals("Sunny",  actual);		
    }
	
	@Test
	public void mockTestWithMockito()
    {
		//Arrange
		WeatherService service = mock(WeatherService.class);
		when(service.getWeather("Rome")).thenReturn("Sunny");
		when(service.getWeather("Cortina")).thenReturn("Snowy");
		
		//Act
		String actual = service.getWeather("Rome");
		
		//Assert
		assertEquals("Sunny",  actual);		
		
		//verify()
		verify(service, atLeastOnce()).getWeather("Rome");
		verify(service, never()).getWeather("Cortina");
    }
}
