# aop.net-tries
Testing AOP under .NET

## Sample output

```
[TestClass(54267293)] TestClass::.ctor
[InstrumentedClassPointcut(58225482)] Testing InstrumentedTestClass[InstrumentedTestClass]::.ctor: True.
[TimingAdvice(41962596)] Created.
[TimingAdvice(41962596)] Bound to instance 42119052.
[TimingAdvice(41962596)] InstrumentedTestClass::.ctor is starting execution
[InstrumentedTestClass(42119052)] TestClass::.ctor
[TimingAdvice(41962596)] InstrumentedTestClass::.ctor finished normally in 0 ms.
[TestClass(54267293)] TestClass::SuccessfulVoidOperation
[InstrumentedClassPointcut(58225482)] Testing InstrumentedTestClass[InstrumentedTestClass]::SuccessfulVoidOperation: True.
[TimingAdvice(25773083)] Created.
[TimingAdvice(25773083)] Bound to instance 42119052.
[TimingAdvice(25773083)] InstrumentedTestClass::SuccessfulVoidOperation is starting execution
[InstrumentedTestClass(42119052)] TestClass::SuccessfulVoidOperation
[TimingAdvice(25773083)] InstrumentedTestClass::SuccessfulVoidOperation finished normally in 0 ms.
[TestClass(54267293)] TestClass::SuccessfulOperationWithReturnValue
[InstrumentedClassPointcut(58225482)] Testing InstrumentedTestClass[InstrumentedTestClass]::SuccessfulOperationWithReturnValue: True.
[TimingAdvice(40362448)] Created.
[TimingAdvice(40362448)] Bound to instance 42119052.
[TimingAdvice(40362448)] InstrumentedTestClass::SuccessfulOperationWithReturnValue is starting execution
[InstrumentedTestClass(42119052)] TestClass::SuccessfulOperationWithReturnValue
[TimingAdvice(40362448)] InstrumentedTestClass::SuccessfulOperationWithReturnValue finished normally in 0 ms and returned '0'.

Experiment 'SuccessfulVoidOperation' results (after 1000000 iterations):
        Reference operation took 1199.5448 ms.
        Test operation took 1807.2071 ms.
Reference operation is faster than test operation in 1.506577411698171 times.
Experiment 'SuccessfulOperationWithReturnValue' results (after 1000000 iterations):
        Reference operation took 922.2231 ms.
        Test operation took 2155.4371 ms.
Reference operation is faster than test operation in 2.3372187272255487 times.
[InstrumentedClassPointcut(58225482)] Testing InstrumentedTestClass[InstrumentedTestClass]::FailedVoidOperation: True.
Experiment 'FailedVoidOperation' results (after 100000 iterations):
        Reference operation took 2536.1289 ms.
        Test operation took 6026.9394 ms.
Reference operation is faster than test operation in 2.3764326016709956 times.
[InstrumentedClassPointcut(58225482)] Testing InstrumentedTestClass[InstrumentedTestClass]::FailedOperationWithReturnValue: True.
Experiment 'FailedOperationWithReturnValue' results (after 100000 iterations):
        Reference operation took 2550.94 ms.
        Test operation took 5528.4952 ms.
Reference operation is faster than test operation in 2.167238429755306 times.

```
