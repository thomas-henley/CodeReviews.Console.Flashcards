﻿namespace FlashCards;

public class CardDto
{
    public int Id { get; set; }
    public string Front { get; set; }
    public string Back { get; set; }
    public int StackId { get; set; }
    public string Name { get; set; }
}