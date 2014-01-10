# FFaker.Net

#### A simple NuGet Package wrapper for Faker.Net that's been forked

This is the project built upon Faker.Net by Jon Wingfield (https://github.com/jonwingfield/Faker.Net)

I forked the NuGet package and then noticed that I couldn't generate a Number easily. What? Oh wait, there it is in FakerRand...puke. And what's with an
additional namespace for exension methods. Why?

What's with all those obsolete methods? Man, that sure is confusing, which do I use?

I can't generate some date's either? Doh.

How about simple numbers? Oh yeah there's that FakerRand thing again. What a strange name. I guess I have to...groan I'm lazy...inspect the source. LOL

#### What I did

I got rid of all the obsolete methods. I removed the extra namespace.

In Lorem: I renamed other methods that didn't make sense, and removed one that was just plain misleading. 
I got rid varying paragraphs. If you want 3 sentences then you get three sentences. If you want between 3 and 5 sentences, then ask for them.
I then introduced some extension methods that made it more english friendly.

Before: Lorem.GetSentences(3)
After: 3.Sentences()

or

3.Paragraphs() -> 3 Paragraphs...this crap could write itself. :P

or

2.Words() -> two words output

And something like this:

Lorem.GetBetween(3, 5).Sentences()
or
Number.Between(3, 5).Sentences() -> same thing
or
Lorem.GetSentences(3, 5)

#### Number

Gives a random number between two values, same as random.Next except english friendly again.
Number.Between(1, 3) 

same with 

Number.Below(10)

#### Date

Same sort of thing here except I put in Past and Future as I noticed that in some cases I just wanted to show dates that were either.

Date.Past(10) -> Generate a date in the past ten days
Date.Past(10, DateType.Month) -> Generate a date in the past month

Date.Between(DateTime.Now.AddDay(-1), DateTime.Now.AddDay(12)) -> Generate a date between yesterday and 12 days from now
or
Date.Between(-1, 12) -> same thing

FYI: I only needed whole date values so this can get better but for now I'm just using Days mostly. 

Warning: No written tests, sorry, I didn't want to write any of this but started and then went deeper than I needed to already.