namespace Km5Store.Migrations
{
	using Models;
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

	internal sealed class Configuration : DbMigrationsConfiguration<Km5Store.Models.Km5StoreContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
		}

		protected override void Seed(Km5Store.Models.Km5StoreContext context)
		{
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data. E.g.
			//
			//    context.People.AddOrUpdate(
			//      p => p.FullName,
			//      new Person { FullName = "Andrew Peters" },
			//      new Person { FullName = "Brice Lambson" },
			//      new Person { FullName = "Rowan Miller" }
			//    );
			//

			context.Movies.AddOrUpdate(x => x.ID, new Movie() { ID = 0, Title = "The Fifth Element", Year = "1977", Rated = "PG-13", Released = "09 May 1997", Runtime = "126 min", Genre = "Action, Adventure, Sci-Fi", Director = "Luc Besson", Writer = "Luc Besson (story), Luc Besson (screenplay), Robert Mark Kamen (screenplay)", Actors = "Bruce Willis, Gary Oldman, Ian Holm, Milla Jovovich", Plot = "In the twenty-third century, the universe is threatened by evil. The only hope for mankind is the Fifth Element, who comes to Earth every five thousand years to protect the humans with four stones of the four elements: fire, water, Earth and air. A Mondoshawan spacecraft is bringing The Fifth Element back to Earth but it is destroyed by the evil Mangalores. However, a team of scientists use the DNA of the remains of the Fifth Element to rebuild the perfect being called Leeloo. She escapes from the laboratory and stumbles upon the taxi driver and former elite commando major Korben Dallas that helps her to escape from the police. Leeloo tells him that she must meet Father Vito Cornelius to accomplish her mission. Meanwhile, the Evil uses the greedy and cruel Jean-Baptiste Emanuel Zorg and a team of mercenary Mangalores to retrieve the stones and avoid the protection of Leeloo. But the skilled Korben Dallas has fallen in love with Leeloo and decides to help her to retrieve the stones.", Language = "English, Swedish, German", Country = "France", Awards = "Nominated for 1 Oscar. Another 9 wins & 33 nominations.", Poster = "http://ia.media-imdb.com/images/M/MV5BMTkzOTkwNTI4N15BMl5BanBnXkFtZTYwMDIzNzI5._V1_SX300.jpg", imdbRating = "7.7" }, new Movie() { ID = 1, Title = "Independence Day", Year = "1996", Rated = "PG-13", Released = "03 Jul 1996", Runtime = "145 min", Genre = "Action, Adventure, Sci-Fi", Director = "Roland Emmerich", Writer = "Dean Devlin, Roland Emmerich", Actors = "Will Smith, Bill Pullman, Jeff Goldblum, Mary McDonnell", Plot = "On July 2nd, communications systems worldwide are sent into chaos by a strange atmospheric interference. It is soon learned by the military that a number of enormous objects are on a collision course with Earth. At first thought to be meteors, they are later revealed to be gigantic spacecraft, piloted by a mysterious alien species. After attempts to communicate with the aliens go nowhere, David Levinson, an ex-scientist turned cable technician, discovers that the aliens are going to attack major points around the globe in less than a day. On July 3rd, the aliens all but obliterate New York, Los Angeles and Washington, as well as Paris, London, Houston and Moscow. The survivors set out in convoys towards Area 51, a strange government testing ground where it is rumored the military has a captured alien spacecraft of their own. The survivors devise a plan to fight back against the enslaving aliens, and July 4th becomes the day humanity will fight for its freedom. July 4th is their Independence Day...", Language = "English", Country = "USA", Awards = "Won 1 Oscar. Another 31 wins & 32 nominations.", Poster = "http://ia.media-imdb.com/images/M/MV5BMTMwODY3NzQzNF5BMl5BanBnXkFtZTcwNzUxNjc0MQ@@._V1_SX300.jpg", imdbRating = "6.9" }, new Movie() { ID = 2, Title = "Frozen", Year = "2013", Rated = "PG", Released = "27 Nov 2013", Runtime = "102 min", Genre = "Animation, Adventure, Comedy", Director = "Chris Buck, Jennifer Lee", Writer = "Jennifer Lee (screenplay), Hans Christian Andersen (story inspired by \"The Snow Queen\" by), Chris Buck (story by), Jennifer Lee (story by), Shane Morris (story by)", Actors = "Kristen Bell, Idina Menzel, Jonathan Groff, Josh Gad", Plot = "When the newly crowned Queen Elsa accidentally uses her power to turn things into ice to curse her home in infinite winter, her sister, Anna, teams up with a mountain man, his playful reindeer, and a snowman to change the weather condition.", Language = "English, Icelandic", Country = "USA", Awards = "Won 2 Oscars. Another 70 wins & 56 nominations.", Poster = "http://ia.media-imdb.com/images/M/MV5BMTQ1MjQwMTE5OF5BMl5BanBnXkFtZTgwNjk3MTcyMDE@._V1_SX300.jpg", imdbRating = "7.6" }, new Movie() { ID = 3, Title = "Furious 7", Year = "2015", Rated = "PG-13", Released = "03 Apr 2015", Runtime = "137 min", Genre = "Action, Crime, Thriller", Director = "James Wan", Writer = "Chris Morgan, Gary Scott Thompson (characters)", Actors = "Vin Diesel, Paul Walker, Jason Statham, Michelle Rodriguez", Plot = "Dominic and his crew thought they'd left the criminal mercenary life behind. They'd defeated international terrorist Owen Shaw and went their separate ways. But now, Shaw's brother, Deckard Shaw, is out killing the crew one by one for revenge. Worse, a Somalian terrorist called Jakarde and a shady government official called \"Mr. Nobody\" are both competing to steal a computer terrorism program called \"God's Eye,\" that can turn any technological device into a weapon. Torretto must reconvene with his team to stop Shaw and retrieve the God's Eye program while caught in a power struggle between the terrorist and the United States government.", Language = "English", Country = "USA", Awards = "Nominated for 1 Golden Globe. Another 17 wins & 24 nominations.", Poster = "http://ia.media-imdb.com/images/M/MV5BMTQxOTA2NDUzOV5BMl5BanBnXkFtZTgwNzY2MTMxMzE@._V1_SX300.jpg", imdbRating = "7.3" }, new Movie() { ID = 4, Title = "Predestination", Year = "2014", Rated = "R", Released = "09 Jan 2015", Runtime = "97 min", Genre = "Drama, Mystery, Sci-Fi", Director = "Michael Spierig, Peter Spierig", Writer = "Michael Spierig, Peter Spierig, Robert A. Heinlein (story \"All You Zombies\")", Actors = "Ethan Hawke, Sarah Snook, Christopher Kirby, Christopher Sommers", Plot = "PREDESTINATION chronicles the life of a Temporal Agent sent on an intricate series of time-travel journeys designed to ensure the continuation of his law enforcement career for all eternity. Now, on his final assignment, the Agent must pursue the one criminal that has eluded him throughout time.", Language = "English", Country = "Australia", Awards = "10 wins & 18 nominations.", Poster = "http://ia.media-imdb.com/images/M/MV5BMTAzODc3NjU1NzNeQTJeQWpwZ15BbWU4MDk5NTQ4NTMx._V1_SX300.jpg", imdbRating = "7.4" }, new Movie() { ID = 5, Title = "The Hunger Games= Catching Fire", Year = "2013", Rated = "PG-13", Released = "22 Nov 2013", Runtime = "146 min", Genre = "Adventure, Sci-Fi, Thriller", Director = "Francis Lawrence", Writer = "Simon Beaufoy (screenplay), Michael Arndt (screenplay), Suzanne Collins (novel)", Actors = "Jennifer Lawrence, Liam Hemsworth, Jack Quaid, Taylor St. Clair", Plot = "Katniss Everdeen and Peeta Mellark become targets of the Capitol after their victory in the 74th Hunger Games sparks a rebellion in the Districts of Panem.", Language = "English", Country = "USA", Awards = "Nominated for 1 Golden Globe. Another 21 wins & 57 nominations.", Poster = "http://ia.media-imdb.com/images/M/MV5BMTAyMjQ3OTAxMzNeQTJeQWpwZ15BbWU4MDU0NzA1MzAx._V1_SX300.jpg", imdbRating = "7.6" });


			context.Artists.AddOrUpdate(x => x.ID,
				new Artist() { ID = 0, name = "Sabrina Carpenter", image = "http://img2-ak.lst.fm/i/u/328fbd766ec5d902f3279442d380fe8b.png", bio = "Sabrina Carpenter (born May 11, 1999 to Elizabeth and David Carpenter) is an American singer and actress from East Greenville, Pennsylvania, USA. Sabrina began dancing at age two and not long after found her unique singing voice. She began vocal training at the age of seven and continues to develop and train her voice as well as learning to play guitar.\n​\nSabrina has released her first full-length album Eyes Wide Open was released on 14th April, 2015.  Sabrina has been signed to Hollywood Records since 2012. \n\nSabrina has also had many starring roles in both TV and in cinema, and is most famous for her current role starring as Maya Hart in Disney Channel series Girl Meets World, since it debuted in 2014.  Sabrina began acting in late 2010 and not long after, booked her first job as a guest star on \"Law & Order SVU\". From there she booked a lead role in the Disney Pilot \"Gulliver Quinn\". She has since played in two movies, 'Noobz\" in 2011 and \"Horns\" in 2012.", url = "http://www.last.fm/music/Sabrina+Carpenter" },
				new Artist() { ID = 1, name = "Taylor Swift", image = "http://img2-ak.lst.fm/i/u/55d5786dbab44b8fcb94713994f951f5.png", bio = "Taylor Alison Swift (born December 13, 1989 in Wyomissing, Pennsylvania) is an American country pop singer-songwriter and actress. Swift is a 8-time Grammy winner with a total of 23 nominations (Feb 2016).\n\nIn 2006, she released her debut single \"Tim McGraw\", then her self-titled debut album, which was subsequently certified multi-platinum by the Recording Industry Association of America.\n\nIn November 2008, Swift released her second album, Fearless, which featured a number of more pop oriented songs such as \"You Belong With Me\" and \"Love Story\". Fearless was the best-selling album in 2009 in the USA and was awarded with 4 Grammy's.\n\nSwift's third and fourth albums, 2010's \"Speak Now\" and 2012's \"Red\", both sold over one million copies within the first week of their US release. “Speak Now” won two Grammy Awards, while “Red’s” singles \" We Are Never Ever Getting Back Together \" and \" I Knew You Were Trouble\" were worldwide hits.\n\nThe 1989 was released on October 27, 2014. It marked a move away from her earlier country sounds and fully into pop. Both the title (\"1989\") and the overall sound of the album - synth pop - were a nod to her birth year and nostalgia with the 1980s. It became the best-selling album of 2014, selling 3.66m copies in USA, and as of April 2015, it had sold 4.5m copies in the US (9m worldwide).  The first single from the album was \"Shake It Off\" (released on August 18, 2014), which reached number one on the Billboard Hot 100.\n\nOn February 15, 2016, Taylor Swift won \"album of the year\" at the 58th Grammy Awards for \"1989\".", url = "http://www.last.fm/music/Taylor+Swift" },
				new Artist() { ID = 2, name = "One Republic", image = "http://img2-ak.lst.fm/i/u/c110a3cb963945cc812568c6bc4a347a.png", bio = "Featuring the anthemic songwriting of Ryan Tedder, OneRepublic rose to prominence in 2007, when \"Apologize\" began its reign as the most popular digital download in American history. Although the song proved to be a quick success, OneRepublic had spent five years touring the musical minor leagues before its release, with Tedder splitting his time between the band's work and production gigs for other artists. Tedder and Zach Filkins formed the band in 2002 and relocated to Los Angeles shortly thereafter, adding keyboardist Drew Brown, bassist/cellist Brent Kutzle, and drummer Eddie Fisher to the lineup in the process. OneRepublic then signed with Sony BMG's Columbia label in 2003; three years later, however, the bandmates returned from a performance at Coachella to find themselves dropped from Columbia's roster.", url = "http://www.last.fm/music/+noredirect/One+Republic" },
				new Artist() { ID = 3, name = "Chromeo", image = "http://img2-ak.lst.fm/i/u/d63643ca125e48e8bc7dc9051040ccc6.png", bio = "Chromeo is an electrofunk duo based in Montreal, Canada and New York City. They are P-Thugg (Patrick Gemayel) on keyboards, synthesizers and talk box, and Dave 1 (David Macklovitch) on guitar and lead vocals. The two were best friends since childhood and officially formed the band in 2002. They describe themselves as the only successful Arab/Jewish collaboration since the beginning of time.\n\nDavid Macklovitch is currently earning his Ph.D in French literature from Columbia University, where he also teaches undergraduate French classes.\n\nHighlights of their 2004 debut album She's In Control include club tracks Needy Girl, Mercury Tears, Rage!, and Destination: Overdrive. In 2005, Chromeo released a mix CD of funky dance tracks on Eskimo Belgium records entitled Un Joli Mix Pour Toi (A Pretty Mix For You). During early 2007 Chromeo supported indie rock group Bloc Party on their British tour.\n\nTheir second album \"Fancy Footwork\", produced by Chromeo themselves with the help of Tiga and mixed by Philippe Zdar from Cassius, was released on June 26th, 2007.\n\nThe album took them on a two-year world tour performing in festivals such as Glastonbury, Reading and Leeds in the UK, Fujirock in Japan, Iceland Airwaves in Iceland, Pemberton Music Festival in Canada and Coachella, Bonnaroo, Rothbury Festival and Lollapalooza in the US.\n\nChromeo contributed to K7's mixed series titled DJ-Kicks: Chromeo. In summer 2010 the track ' Fancy Footwork' was used as the sound track for a VO5 Extreme Hair Gel advertisement in the UK. The YouTube video of the original release in 2008 had over 666,000 hits by late July 2010.\n\nChromeo released their third studio album entitled \"Business Casual\" on September 14, 2010.\n\nTheir song \" Don't Turn The Lights On\" is featured on the video game FIFA 11 exposing them to a new group of listeners. In 2011 the same song was also featured on the video game Dirt3. Their song Bonified Lovin (Yuksek remix) is also on the video game FIFA 09.\n\nAt the beginning of March 2011, Chromeo sent out notice that it had recorded the \"world's smallest album,\" entitled Drive Time, which consists of 55 songs in only 183 seconds. About a week later, it was revealed that Drive Time is actually a free musical Nokia Own Voice satellite navigation pack for Ovi Maps, made for usage with Nokia's compatible cell phones. A red vinyl 5\" single consisting of regular, instrumental and a cappella versions of \"Turn Left\" and \"Follow\" was released to promote it, with a sticker on the shrink wrap saying that it was a numbered limited edition of 40 copies.", url = "http://www.last.fm/music/Chromeo" },
				new Artist() { ID = 4, name = "Avril Lavigne", image = "http://img2-ak.lst.fm/i/u/8edc565e985b4acabef2122317889c30.png", bio = "Avril Ramona Lavigne (born on September 27, 1984 in Belleville, Ontario, Canada), professionally known as Avril Lavigne, is a Juno award-winning and Grammy-award nominated pop rock singer, songwriter. In 2002, Lavigne reached mainstream success after her debut single, Complicated, and her debut album Let Go, gained lots of media attention and honourably earned her reputation of a 'skater punk' persona and 'pop punk princess' when she was only 17 years old. Since her professional debut, Lavigne's honors notably are 8 Grammy award nominations as well as 8 Juno awards from 24 nominations. Lavigne is one of the top-selling artists releasing albums in the US, with over 11 million copies certified by the RIAA. To date, Lavigne has had 8 Top 20 Billboard Hot 100 hits, including the best-selling single in 2007, Girlfriend, which was released as the lead single from her third studio album, The Best Damn Thing. Lavigne has released 5 Top 5 Billboard 200 studio albums: Let Go (2002), Under My Skin (2004), The Best Damn Thing (2007), Goodbye Lullaby (2011), and Avril Lavigne (2013). As of April 2013, Lavigne has sold more than 30 million albums and 50 million singles worldwide.\nPersonal Life - in July 2013, Lavigne married Nickelback and fellow Canadian, Chad Kroeger. The couple met in July 2012 while working on Lavigne's single \"Here's To Never Growing Up\" and Kroeger proposed 1 month later. On Sept 3, 2015, after 2 years of marriage, the couple announced that they were separating.", url = "http://www.last.fm/music/Avril+Lavigne" }
				);


			context.Albums.AddOrUpdate(x => x.ID,
				new Album()
				{
					ID = 0,
					Artist = 0,
					Name = "Eyes Wide Open",
					Url = "http://www.last.fm/music/Sabrina+Carpenter/Eyes+Wide+Open",
					Image = "http://img2-ak.lst.fm/i/u/385cb47c90284b2ecb5b53e7e3d3cb30.png",
					Listeners = "5767",
					Playcount = "84832"
				},
				new Album()
				{
					ID = 1,
					Artist = 0,
					Name = "Smoke and Fire",
					Url = "http://www.last.fm/music/Sabrina+Carpenter/Smoke+and+Fire",
					Image = "http://img2-ak.lst.fm/i/u/f8750ffd39d877105eb5a5d0812ce0bd.png",
					Listeners = "1309",
					Playcount = "4066"
				},
				new Album()
				{
					ID = 2,
					Artist = 1,
					Name = "1989",
					Image = "http://img2-ak.lst.fm/i/u/7eb6cacc9dae4d3ccd436317add8cf4c.png",
					Url = "http://www.last.fm/music/Taylor+Swift/1989",
					Listeners = "92014",
					Playcount = "9146458"
				},
				new Album()
				{
					ID = 3,
					Artist = 1,
					Name = "Speak Now",
					Image = "http://img2-ak.lst.fm/i/u/33f329a207cd48d5935617080eda0ea0.png",
					Url = "http://www.last.fm/music/Taylor+Swift/Speak+Now",
					Listeners = "370710",
					Playcount = "10753353"
				},
				new Album()
				{
					ID = 4,
					Artist = 1,
					Name = "Fearless",
					Url = "http://www.last.fm/music/Taylor+Swift/Fearless",
					Image = "http://img2-ak.lst.fm/i/u/11b179a18eb7456c8cce4a85f0b35cea.png",
					Listeners = "828720",
					Playcount = "19421515"
				},
				new Album()
				{
					ID = 5,
					Artist = 2,
					Name = "Native",
					Url = "http://www.last.fm/music/One+Republic/Native",
					Image = "http://img2-ak.lst.fm/i/u/69c2cf452df94590a8b4af1e431ef458.png",
					Listeners = "0",
					Playcount = "0"
				},
				new Album()
				{
					ID = 6,
					Artist = 3,
					Name = "White Women",
					Image = "http://img2-ak.lst.fm/i/u/057822d679dc429ec276a0a324a1138a.png",
					Url = "http://www.last.fm/music/Chromeo/White+Women",
					Listeners = "104073",
					Playcount = "1562354"
				},
				new Album()
				{
					ID = 7,
					Artist = 4,
					Name = "Avril Lavigne",
					Image = "http://img2-ak.lst.fm/i/u/4e775debb1cb445e9f711e34bfba2715.png",
					Url = "http://www.last.fm/music/Avril+Lavigne/Avril+Lavigne",
					Listeners = "120378",
					Playcount = "4959505"
				},
				new Album()
				{
					ID = 8,
					Artist = 4,
					Name = "Let Go",
					Image = "http://img2-ak.lst.fm/i/u/5cf851439e0945dec5573aac4a9553f6.png",
					Url = "http://www.last.fm/music/Avril+Lavigne/Let+Go",
					Playcount = "18449468",
					Listeners = "1018005"
				});
		}
	}
}
