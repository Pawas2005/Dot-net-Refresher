using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamPortalApp;

public abstract class Question
{
    public int Id { get; }
    public string Text { get; }
    public string Category { get; }
    public string Topic { get; }

    protected Question(int id, string text, string category, string topic)
    {
        Id = id;
        Text = text;
        Category = category;
        Topic = topic;
    }

    public abstract string QuestionType { get; }

    public override string ToString()
    {
        return $"[{Id}] {QuestionType} | Category: {Category} | Topic: {Topic} | {Text}";
    }
}

public class MultipleChoiceQuestion : Question
{
    public List<string> Options { get; }

    public MultipleChoiceQuestion(int id, string text, string category, string topic, List<string> options)
        : base(id, text, category, topic)
    {
        Options = options;
    }

    public override string QuestionType => "Multiple Choice";
}

public class ParagraphQuestion : Question
{
    public ParagraphQuestion(int id, string text, string category, string topic)
        : base(id, text, category, topic)
    {
    }

    public override string QuestionType => "Paragraph";
}

public class ExamPortal
{
    private readonly List<Question> _questions = new();

    public void AddQuestion(Question question)
    {
        _questions.Add(question);
    }

    public int GetTotalQuestionCount()
    {
        return _questions.Count;
    }

    public List<Question> GetQuestionsByTopic(string topic)
    {
        return _questions
            .Where(question => question.Topic.Equals(topic, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    public List<Question> GetQuestionsByTopicAndCategory(string topic, string category)
    {
        return _questions
            .Where(question => question.Topic.Equals(topic, StringComparison.OrdinalIgnoreCase)
                            && question.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}

public static class Program
{
    public static void Main()
    {
        var examPortal = new ExamPortal();

        examPortal.AddQuestion(new MultipleChoiceQuestion(
            1,
            "What is the capital of India?",
            "Geography",
            "Countries",
            new List<string> { "Delhi", "Mumbai", "Chennai", "Kolkata" }));

        examPortal.AddQuestion(new ParagraphQuestion(
            2,
            "Explain the importance of object-oriented programming.",
            "Programming",
            "OOP"));

        examPortal.AddQuestion(new MultipleChoiceQuestion(
            3,
            "Which keyword is used to inherit a class in C#?",
            "Programming",
            "CSharp",
            new List<string> { "inherits", ":", "base", "this" }));

        examPortal.AddQuestion(new ParagraphQuestion(
            4,
            "Write a short note on the water cycle.",
            "Science",
            "Environment"));

        Console.WriteLine($"Total number of questions: {examPortal.GetTotalQuestionCount()}");

        Console.WriteLine("\nQuestions for topic 'CSharp':");
        foreach (var question in examPortal.GetQuestionsByTopic("CSharp"))
        {
            Console.WriteLine(question);
        }

        Console.WriteLine("\nQuestions for topic 'OOP' and category 'Programming':");
        foreach (var question in examPortal.GetQuestionsByTopicAndCategory("OOP", "Programming"))
        {
            Console.WriteLine(question);
        }
    }
}