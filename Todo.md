# RpnCalculatorApi
RPN calculator manage only one stack in process, a better way is to use a dictionary for stack with Guid keys

## ToDo
1. Add a dictioanry of stacks
	* Add a route to create a new stack that return the id of the created stack
	* Add rooute to display all the stack of the dictionary
2. Add unit tests for CalculatorService with mocking properties with interfaces types
3. Add new route to return all valid operators
4. Use concurrentStack instead of concurrent