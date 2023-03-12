ООП

полиморфизм
- подтипов
- параметрический
- Ad-hoc

Тестирование

Класс_Метод_Сценарий_ОжидаемоеПоведение

Arrange  - инициализация
Act      - действие
Assert   - проверка

Person_GetGreeting_SmallAge_CorrectAnswer

// Arrange
var p = new Person()
{
  ...
};

// Act
var greeting = p.GetGreeting();

// Assert
Assert.That(greeting, Is.EqualTo("Hi, Bob"));

[Test]
[TestCase()]