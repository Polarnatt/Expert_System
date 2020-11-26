using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int n = 0;
        int x = 0;
        int y = 0;
        int z = 0;
        int w = 0;
        
        string answer1_1 = "If you pay the slightest attention to what people wear in the office, you’ve surely noticed how men’s business attire has changed over the years.\n" +
            "Men’s office wear is now a lot more casual than ever before.That’s mostly thanks to the IT department and Hawaii." +
            "That’s not a bad thing.\n" +
            "Being more casual at work breaks the rigid style rules and gives you more space to express your personality." + "\n" + "\n";
        
        string answer1_2 = "Casual dress code for men is perhaps men’s best chance to express a true sense of personal style.\n" +
            "Whether you prefer something sleek or rugged, upscale or down-to-earth, men’s casual wear is an open invitation to dress in what feels most comfortable to you.\n" +
            "Rather than focusing on formalities, dressing casually is about finding the right balance between comfort, individuality, and style – think fashionable yet functional outfits." + "\n" + "\n";
        
        string answer1_3 = "Are you lucky enough to be invited to an event requiring a white tie dress?\n" +
            " Consider yourself lucky! " +
            "White tie is the most formal of all dress codes and typically associated with presidential dinners, royal affairs, as well as state dinners and formal balls." +
            " It is a dress code that leaves little room for personal interpretation.\n" +
            "Thus, it is imperative you follow a strict dress guideline." +
            " Below is all the information you need to know that will insure your attire is up to par." + "\n" + "\n";
        
        string answer2_1 = "If your job requires you to follow a formal dress code, just think about Michelle Obama.\n" +
            "\"Style helps distinguish you,\" she says. " +
            "\"It\'s a great potential opportunity that people tend to leave by the wayside.\"\n " +
            "According to Obama, style is available at any time, and let\'s face it, the ex-lawyer has an impressive wardrobe that spans presidential elections and functions that most of us will never have to endure." +
            "But when your attire is determined by the company dress code, what\'s a non-First Lady to do?" + "\n" + "\n";
        
        string answer2_2 = "Dress codes are tricky, and while we’ve all heard of smart casual before, the term can still cause confusion and panic for many.\n" +
            "Luckily, we’re here to help by shedding some much-needed light on this ambiguous type of attire.\n" +
            "So, if you’ve been wondering what smart casual means or you are after some stylish outfit ideas to suit it, we’ve got you covered. " +
            "This is your handy guide to the smart casual dress code for women." + "\n" + "\n";
        
        string answer2_3 = "Are you lucky enough to be invited to an event requiring a white tie dress?\n" +
            " Consider yourself lucky! " +
            "White tie is the most formal of all dress codes and typically associated with presidential dinners, royal affairs, as well as state dinners and formal balls.\n" +
            " It is a dress code that leaves little room for personal interpretation. " +
            "Thus, it is imperative you follow a strict dress guideline." +
            " Below is all the information you need to know that will insure your attire is up to par." + "\n" + "\n";
        // last third fourth question
        string answer1_1_1_1 = "The best choice for you would be: " + " \n\n" +
            "1. Double-brested jackets\n" +
            "2. Waistcoats & Vests\n" +
            "3. Clothes with textured weaves\n" +
            "4. Belts\n" +
            "5. Patterned shoes\n\n" +
            "What to avoid?\n" +
            "1. Strong vertical stripes\n" +
            "2. Solid monochrome suits\n" +
            "3. Shorts & t-shirts";
        string answer1_1_1_2 = "The best choice for you would be: " + " \n\n" +
            "1. Double-brested jackets\n" +
            "2. Waistcoats & Vests\n" +
            "3. Clothes with textured weaves\n" +
            "4. Belts\n" +
            "5. Patterned shoes\n\n" +
            "What to avoid?\n" +
            "1. Strong vertical stripes\n" +
            "2. Solid monochrome suits\n" +
            "3. Shorts & t-shirts";
        string answer1_1_1_3 = "The best choice for you would be: " + " \n\n" +
            "1. Double-brested jackets\n" +
            "2. Waistcoats & Vests\n" +
            "3. Clothes with textured weaves\n" +
            "4. Belts\n" +
            "5. Patterned shoes\n\n" +
            "What to avoid?\n" +
            "1. Strong vertical stripes\n" +
            "2. Solid monochrome suits\n" +
            "3. Shorts & t-shirts";
        string answer1_1_2_1 = "The best choice for you would be: " + " \n\n" +
            "1. Well-build suit, that sits perfectly on you\n" +
            "2. A set of button-up collared shirts\n" +
            "3. Add subtlety with your ties\n" +
            "4. Oxford shoes\n" +
            "5. Evaluate your business look with the right accessories(pocket squares, cufflinks, watches)\n\n" +
            "What to avoid?\n" +
            "1. Casual clothes\n" +
            "2. Avoid bright colors or busy patterns\n" +
            "3. Avoid wearing brown shoes if you select a black suit";
        string answer1_1_2_2 = "The best choice for you would be: " + " \n\n" +
            "1. Well-build suit, that sits perfectly on you\n" +
            "2. A set of button-up collared shirts\n" +
            "3. Add subtlety with your ties\n" +
            "4. Oxford shoes\n" +
            "5. Evaluate your business look with the right accessories(pocket squares, cufflinks, watches)\n\n" +
            "What to avoid?\n" +
            "1. Casual clothes\n" +
            "2. Avoid bright colors or busy patterns\n" +
            "3. Avoid wearing brown shoes if you select a black suit";
        string answer1_1_2_3 = "The best choice for you would be: " + " \n\n" +
            "1. Well-build suit, that sits perfectly on you\n" +
            "2. A set of button-up collared shirts\n" +
            "3. Add subtlety with your ties\n" +
            "4. Oxford shoes\n" +
            "5. Evaluate your business look with the right accessories(pocket squares, cufflinks, watches)\n\n" +
            "What to avoid?\n" +
            "1. Casual clothes\n" +
            "2. Avoid bright colors or busy patterns\n" +
            "3. Avoid wearing brown shoes if you select a black suit";
        string answer1_1_3_1 = "The best choice for you would be: " + " \n\n" +
            "1. Low-contrasting or monochrome clothes and shoes\n" +
            "2. Wear a pointed toe shoe\n" +
            "3. Keep the shoe below the ankle\n" +
            "4. Shorter jackets\n" +
            "5. Narrower lapels\n" +
            "6. Slimmer sleeve widths\n" +
            "7. Higher buttons\n" +
            "8. Long topcoats\n" +
            "9. Use accessory(socks, hats and scarves, belts)\n\n" +
            "What to avoid?\n" +
            "1. Avoid bright colors or busy patterns\n" +
            "2. Avoid tight clothes";
        string answer1_1_3_2 = "The best choice for you would be: " + " \n\n" +
            "1. Low-contrasting or monochrome clothes and shoes\n" +
            "2. Wear a pointed toe shoe\n" +
            "3. Keep the shoe below the ankle\n" +
            "4. Shorter jackets\n" +
            "5. Narrower lapels\n" +
            "6. Slimmer sleeve widths\n" +
            "7. Higher buttons\n" +
            "8. Long topcoats\n" +
            "9. Use accessory(socks, hats and scarves, belts)\n\n" +
            "What to avoid?\n" +
            "1. Avoid bright colors or busy patterns\n" +
            "2. Avoid tight clothes";
        string answer1_1_3_3 = "The best choice for you would be: " + " \n\n" +
            "1. Low-contrasting or monochrome clothes and shoes\n" +
            "2. Wear a pointed toe shoe\n" +
            "3. Keep the shoe below the ankle\n" +
            "4. Shorter jackets\n" +
            "5. Narrower lapels\n" +
            "6. Slimmer sleeve widths\n" +
            "7. Higher buttons\n" +
            "8. Long topcoats\n" +
            "9. Use accessory(socks, hats and scarves, belts)\n\n" +
            "What to avoid?\n" +
            "1. Avoid bright colors or busy patterns\n" +
            "2. Avoid tight clothes";
        string answer1_2_1_1 = "The best choice for you would be clothes, that: " + " \n\n" +
            "1. Adequate length in sleeves and trouser legs\n" +
            "2. Sufficient shoulder width to keep shirts from pinching\n" +
            "3. Long shirttails that can be tucked in securely\n" +
            "4. Enough room in the crotch (the “drop”) to keep trousers from pinching\n" +
            "5. A close fit (especially in jackets) to prevent billowing\n" +
            "6. Unimposing patterns and colors to keep him from looking overwhelming\n\n" +
            "What to avoid?\n" +
            "1. Strong vertical stripes\n" +
            "2. Solid monochrome suits\n" +
            "3. Shorts & t-shirts";
        string answer1_2_1_2 = "The best choice for you would be clothes, that: " + " \n\n" +
            "1. Adequate length in sleeves and trouser legs\n" +
            "2. Sufficient shoulder width to keep shirts from pinching\n" +
            "3. Long shirttails that can be tucked in securely\n" +
            "4. Enough room in the crotch (the “drop”) to keep trousers from pinching\n" +
            "5. A close fit (especially in jackets) to prevent billowing\n" +
            "6. Unimposing patterns and colors to keep him from looking overwhelming\n\n" +
            "What to avoid?\n" +
            "1. Strong vertical stripes\n" +
            "2. Solid monochrome suits\n" +
            "3. Shorts & t-shirts";
        string answer1_2_1_3 = "The best choice for you would be clothes, that: " + " \n\n" +
            "1. Adequate length in sleeves and trouser legs\n" +
            "2. Sufficient shoulder width to keep shirts from pinching\n" +
            "3. Long shirttails that can be tucked in securely\n" +
            "4. Enough room in the crotch (the “drop”) to keep trousers from pinching\n" +
            "5. A close fit (especially in jackets) to prevent billowing\n" +
            "6. Unimposing patterns and colors to keep him from looking overwhelming\n\n" +
            "What to avoid?\n" +
            "1. Strong vertical stripes\n" +
            "2. Solid monochrome suits\n" +
            "3. Shorts & t-shirts";
        string answer1_2_2_1 = "The best choice for you would be: " + " \n\n" +
            "1. T-shirts\n" +
            "2. Button-down shirts\n" +
            "3. Sweaters\n" +
            "4. Jeans, khaki pants or shorts\n" +
            "5. Sneakers, loafers or sandals\n\n" +
            "What to avoid?\n" +
            "1. Anything formal, or can be described as some party stuff";
        string answer1_2_2_2 = "The best choice for you would be: " + " \n\n" +
            "1. T-shirts\n" +
            "2. Button-down shirts\n" +
            "3. Sweaters\n" +
            "4. Jeans, khaki pants or shorts\n" +
            "5. Sneakers, loafers or sandals\n\n" +
            "What to avoid?\n" +
            "1. Anything formal, or can be described as some party stuff";
        string answer1_2_2_3 = "The best choice for you would be: " + " \n\n" +
            "1. T-shirts\n" +
            "2. Button-down shirts\n" +
            "3. Sweaters\n" +
            "4. Jeans, khaki pants or shorts\n" +
            "5. Sneakers, loafers or sandals\n\n" +
            "What to avoid?\n" +
            "1. Anything formal, or can be described as some party stuff";
        string answer1_2_3_1 = "The best choice for you would be: " + " \n\n" +
            "1. Wear low contrast outfits\n" +
            "2. Choose small scale patterns\n" +
            "3. Wear proportionate accessories\n" +
            "4. Wear height boosting shoes\n\n" +
            "" +
            "What to avoid?\n" +
            "1. Avoid loose fitting clothes\n" +
            "2. Avoid oversized details\n" + 
            "3. Avoid bulky outerwear\n";
        string answer1_2_3_2 = "The best choice for you would be: " + " \n\n" +
            "1. Wear low contrast outfits\n" +
            "2. Choose small scale patterns\n" +
            "3. Wear proportionate accessories\n" +
            "4. Wear height boosting shoes\n\n" +
            "" +
            "What to avoid?\n" +
            "1. Avoid loose fitting clothes\n" +
            "2. Avoid oversized details\n" +
            "3. Avoid bulky outerwear\n";
        string answer1_2_3_3 = "The best choice for you would be: " + " \n\n" +
            "1. Wear low contrast outfits\n" +
            "2. Choose small scale patterns\n" +
            "3. Wear proportionate accessories\n" +
            "4. Wear height boosting shoes\n\n" +
            "" +
            "What to avoid?\n" +
            "1. Avoid loose fitting clothes\n" +
            "2. Avoid oversized details\n" +
            "3. Avoid bulky outerwear\n";
        string answer1_3_1_1 = "The best choice for you would be: " + " \n\n" +
            "1. Evening tailcoat\n" +
            "2. Evening trousers\n" +
            "3. Waistcoat\n" +
            "4. Shirt or white marcella\n" +
            "5. Oxford shoes\n\n" +
            "What to avoid?\n" +
            "1. Casual clothes\n" +
            "2. Avoid bright colors or busy patterns\n" +
            "3. Avoid wearing brown shoes if you select a black suit";
        string answer1_3_1_2 = "The best choice for you would be: " + " \n\n" +
            "1. Evening tailcoat\n" +
            "2. Evening trousers\n" +
            "3. Waistcoat\n" +
            "4. Shirt or white marcella\n" +
            "5. Oxford shoes\n\n" +
            "What to avoid?\n" +
            "1. Casual clothes\n" +
            "2. Avoid bright colors or busy patterns\n" +
            "3. Avoid wearing brown shoes if you select a black suit";
        string answer1_3_1_3 = "The best choice for you would be: " + " \n\n" +
            "1. Evening tailcoat\n" +
            "2. Evening trousers\n" +
            "3. Waistcoat\n" +
            "4. Shirt or white marcella\n" +
            "5. Oxford shoes\n\n" +
            "What to avoid?\n" +
            "1. Casual clothes\n" +
            "2. Avoid bright colors or busy patterns\n" +
            "3. Avoid wearing brown shoes if you select a black suit";
        string answer1_3_2_1 = "The best choice for you would be: " + " \n\n" +
            "1. Evening tailcoat\n" +
            "2. Evening trousers\n" +
            "3. Waistcoat\n" +
            "4. Shirt or white marcella\n" +
            "5. Oxford shoes\n\n" +
            "What to avoid?\n" +
            "1. Casual clothes\n" +
            "2. Avoid bright colors or busy patterns\n" +
            "3. Avoid wearing brown shoes if you select a black suit";
        string answer1_3_2_2 = "The best choice for you would be: " + " \n\n" +
            "1. Evening tailcoat\n" +
            "2. Evening trousers\n" +
            "3. Waistcoat\n" +
            "4. Shirt or white marcella\n" +
            "5. Oxford shoes\n\n" +
            "What to avoid?\n" +
            "1. Casual clothes\n" +
            "2. Avoid bright colors or busy patterns\n" +
            "3. Avoid wearing brown shoes if you select a black suit";
        string answer1_3_2_3 = "The best choice for you would be: " + " \n\n" +
            "1. Evening tailcoat\n" +
            "2. Evening trousers\n" +
            "3. Waistcoat\n" +
            "4. Shirt or white marcella\n" +
            "5. Oxford shoes\n\n" +
            "What to avoid?\n" +
            "1. Casual clothes\n" +
            "2. Avoid bright colors or busy patterns\n" +
            "3. Avoid wearing brown shoes if you select a black suit";
        string answer1_3_3_1 = "The best choice for you would be: " + " \n\n" +
            "1. Evening tailcoat\n" +
            "2. Evening trousers\n" +
            "3. Waistcoat\n" +
            "4. Shirt or white marcella\n" +
            "5. Oxford shoes\n\n" +
            "What to avoid?\n" +
            "1. Avoid casual clothes\n" +
            "2. Avoid bright colors or busy patterns\n" +
            "3. Avoid wearing brown shoes if you select a black suit" +
            "4. Avoid loose fitting clothes\n" +
            "5. Avoid oversized details\n" +
            "6. Avoid bulky outerwear\n";
        string answer1_3_3_2 = "The best choice for you would be: " + " \n\n" +
            "1. Evening tailcoat\n" +
            "2. Evening trousers\n" +
            "3. Waistcoat\n" +
            "4. Shirt or white marcella\n" +
            "5. Oxford shoes\n\n" +
            "What to avoid?\n" +
            "1. Avoid casual clothes\n" +
            "2. Avoid bright colors or busy patterns\n" +
            "3. Avoid wearing brown shoes if you select a black suit" +
            "4. Avoid loose fitting clothes\n" +
            "5. Avoid oversized details\n" +
            "6. Avoid bulky outerwear\n";
        string answer1_3_3_3 = "The best choice for you would be: " + " \n\n" +
            "1. Evening tailcoat\n" +
            "2. Evening trousers\n" +
            "3. Waistcoat\n" +
            "4. Shirt or white marcella\n" +
            "5. Oxford shoes\n\n" +
            "What to avoid?\n" +
            "1. Avoid casual clothes\n" +
            "2. Avoid bright colors or busy patterns\n" +
            "3. Avoid wearing brown shoes if you select a black suit" +
            "4. Avoid loose fitting clothes\n" +
            "5. Avoid oversized details\n" +
            "6. Avoid bulky outerwear\n";
        // --- 
        string answer2_1_1_1 = "The best choice for you would be: " + " \n\n" +
            "1. Tidy dress, skirt or slack\n" +
            "2. Near button-down shirts or blouses with a blazer\n" +
            "3. Classic heels, loafers or tidy flats\n" +
            "4. Minimal jewelry and belts\n\n" +
            "What to avoid?\n" +
            "1. 1. Casual clothes\n" +
            "2. Avoid bright colors or busy patterns";
        string answer2_1_1_2 = "The best choice for you would be: " + " \n\n" +
            "1. Tidy dress, skirt or slack\n" +
            "2. Near button-down shirts or blouses with a blazer\n" +
            "3. Classic heels, loafers or tidy flats\n" +
            "4. Minimal jewelry and belts\n\n" +
            "What to avoid?\n" +
            "1. Casual clothes\n" +
            "2. Avoid bright colors or busy patterns";
        string answer2_1_1_3 = "The best choice for you would be: " + " \n\n" +
            "1. Tidy dress, skirt or slack\n" +
            "2. Near button-down shirts or blouses with a blazer\n" +
            "3. Classic heels, loafers or tidy flats\n" +
            "4. Minimal jewelry and belts\n\n" +
            "What to avoid?\n" +
            "1. Casual clothes\n" +
            "2. Avoid bright colors or busy patterns";
        string answer2_1_2_1 = "The best choice for you would be: " + " \n\n" +
            "1. Pencil skirt\n" +
            "2. Trousers\n" +
            "3. Blazers or sweaters\n" +
            "4. Flats, loafers, boots or heels\n\n" +
            "What to avoid?\n" +
            "1. Casual clothes\n" +
            "2. Avoid bright colors or busy patterns";
        string answer2_1_2_2 = "The best choice for you would be: " + " \n\n" +
            "1. Pencil skirt\n" +
            "2. Trousers\n" +
            "3. Blazers or sweaters\n" +
            "4. Flats, loafers, boots or heels\n\n" +
            "What to avoid?\n" +
            "1. Casual clothes\n" +
            "2. Avoid bright colors or busy patterns";
        string answer2_1_2_3 = "The best choice for you would be: " + " \n\n" +
            "1. Pencil skirt\n" +
            "2. Trousers\n" +
            "3. Blazers or sweaters\n" +
            "4. Flats, loafers, boots or heels\n\n" +
            "What to avoid?\n" +
            "1. Casual clothes\n" +
            "2. Avoid bright colors or busy patterns";
        string answer2_1_3_1 = "The best choice for you would be: " + " \n\n" +
            "1. Dark pants suit, skirt suit or suit dress\n" +
            "2. Flats, heels, oxfords or loafers\n" +
            "3. Minimal jewelry\n\n" +
            "What to avoid?\n" +
            "1. Casual clothes\n" +
            "2. Avoid bright colors or busy patterns";
        string answer2_1_3_2 = "The best choice for you would be: " + " \n\n" +
            "1. Dark pants suit, skirt suit or suit dress\n" +
            "2. Flats, heels, oxfords or loafers\n" +
            "3. Minimal jewelry\n\n" +
            "What to avoid?\n" +
            "1. Casual clothes\n" +
            "2. Avoid bright colors or busy patterns";
        string answer2_1_3_3 = "The best choice for you would be: " + " \n\n" +
            "1. Dark pants suit, skirt suit or suit dress\n" +
            "2. Flats, heels, oxfords or loafers\n" +
            "3. Minimal jewelry\n\n" +
            "What to avoid?\n" +
            "1. Casual clothes\n" +
            "2. Avoid bright colors or busy patterns";
        string answer2_2_1_1 = "The best choice for you would be: " + " \n\n" +
            "1. T-shirt, blouse and sweater on top\n" +
            "2. Jeans, cropped pants or shorts\n" +
            "3. Sneakers, low heels or sandals\n\n" +
            "What to avoid?\n" +
            "1. Nothing, actually. Just be true with yourself and wear what you like the most";
        string answer2_2_1_2 = "The best choice for you would be: " + " \n\n" +
            "1. T-shirt, blouse and sweater on top\n" +
            "2. Jeans, cropped pants or shorts\n" +
            "3. Sneakers, low heels or sandals\n\n" +
            "What to avoid?\n" +
            "1. Nothing, actually. Just be true with yourself and wear what you like the most";
        string answer2_2_1_3 = "The best choice for you would be: " + " \n\n" +
            "1. T-shirt, blouse and sweater on top\n" +
            "2. Jeans, cropped pants or shorts\n" +
            "3. Sneakers, low heels or sandals\n\n" +
            "What to avoid?\n" +
            "1. Nothing, actually. Just be true with yourself and wear what you like the most";
        string answer2_2_2_1 = "The best choice for you would be: " + " \n\n" +
            "1. Blazer, sweater or t-shirt\n" +
            "2. Skinny knee-length skirt, printed skirt or skater skirt\n" +
            "3. Vibrant color dresses\n" +
            "4. Designer tops\n\n" +
            "What to avoid?\n" +
            "1. Nothing, actually. Just be true with yourself and wear what you like the most";
        string answer2_2_2_2 = "The best choice for you would be: " + " \n\n" +
            "1. Blazer, sweater or t-shirt\n" +
            "2. Skinny knee-length skirt, printed skirt or skater skirt\n" +
            "3. Vibrant color dresses\n" +
            "4. Designer tops\n\n" +
            "What to avoid?\n" +
            "1. Nothing, actually. Just be true with yourself and wear what you like the most";
        string answer2_2_2_3 = "The best choice for you would be: " + " \n\n" +
            "1. Blazer, sweater or t-shirt\n" +
            "2. Skinny knee-length skirt, printed skirt or skater skirt\n" +
            "3. Vibrant color dresses\n" +
            "4. Designer tops\n\n" +
            "What to avoid?\n" +
            "1. Nothing, actually. Just be true with yourself and wear what you like the most";
        string answer2_2_3_1 = "The best choice for you would be: " + " \n\n" +
            "1. Skin baring top\n" +
            "2. Mid-length skirt\n" +
            "3. Fitted or knit pants\n" +
            "4. Long sleeve blouse\n" +
            "5. Pencil skirt\n" +
            "6. Simple tailored dress\n" +
            "7. Cotton-shirts\n\n" +
            "What to avoid?\n" +
            "1. Nothing, actually. Just be true with yourself and wear what you like the most";
        string answer2_2_3_2 = "The best choice for you would be: " + " \n\n" +
            "1. Skin baring top\n" +
            "2. Mid-length skirt\n" +
            "3. Fitted or knit pants\n" +
            "4. Long sleeve blouse\n" +
            "5. Pencil skirt\n" +
            "6. Simple tailored dress\n" +
            "7. Cotton-shirts\n\n" +
            "What to avoid?\n" +
            "1. Nothing, actually. Just be true with yourself and wear what you like the most";
        string answer2_2_3_3 = "The best choice for you would be: " + " \n\n" +
            "1. Skin baring top\n" +
            "2. Mid-length skirt\n" +
            "3. Fitted or knit pants\n" +
            "4. Long sleeve blouse\n" +
            "5. Pencil skirt\n" +
            "6. Simple tailored dress\n" +
            "7. Cotton-shirts\n\n" +
            "What to avoid?\n" +
            "1. Nothing, actually. Just be true with yourself and wear what you like the most";
        string answer2_3_1_1 = "The best choice for you would be: " + " \n\n" +
            "1. Cocktail or knee-length dress\n" +
            "2. Full-lenght A-line\n" +
            "3. Floor-length powder blue dress\n\n" +
            "What to avoid?" +
            "1. Avoid anything casual or even office clothes\n" +
            "2. Avoid too much jewelry\n" +
            "3. Avoid eye-beating colors";
        string answer2_3_1_2 = "The best choice for you would be: " + " \n\n" +
            "1. Cocktail or knee-length dress\n" +
            "2. Full-lenght A-line\n" +
            "3. Floor-length powder blue dress\n\n" +
            "What to avoid?" +
            "1. Avoid anything casual or even office clothes\n" +
            "2. Avoid too much jewelry\n" +
            "3. Avoid eye-beating colors";
        string answer2_3_1_3 = "The best choice for you would be: " + " \n\n" +
            "1. Cocktail or knee-length dress\n" +
            "2. Full-lenght A-line\n" +
            "3. Floor-length powder blue dress\n\n" +
            "What to avoid?" +
            "1. Avoid anything casual or even office clothes\n" +
            "2. Avoid too much jewelry\n" +
            "3. Avoid eye-beating colors";
        string answer2_3_2_1 = "The best choice for you would be: " + " \n\n" +
            "1. Pleated deep-V gown dress\n" +
            "2. To the floor gown\n" +
            "3. Shoes, that match your gown\n" +
            "4. Vintage or Couture jewelry" +
            "What to avoid?" +
            "1. Avoid anything casual, semi-formal and office clothes\n" +
            "2. Avoid too much jewelry\n" +
            "3. Avoid eye-beating colors";
        string answer2_3_2_2 = "The best choice for you would be: " + " \n\n" +
            "1. Pleated deep-V gown dress\n" +
            "2. To the floor gown\n" +
            "3. Shoes, that match your gown\n" +
            "4. Vintage or Couture jewelry" +
            "What to avoid?" +
            "1. Avoid anything casual, semi-formal and office clothes\n" +
            "2. Avoid too much jewelry\n" +
            "3. Avoid eye-beating colors";
        string answer2_3_2_3 = "The best choice for you would be: " + " \n\n" +
            "1. Pleated deep-V gown dress\n" +
            "2. To the floor gown\n" +
            "3. Shoes, that match your gown\n" +
            "4. Vintage or Couture jewelry\n\n" +
            "What to avoid?" +
            "1. Avoid anything casual, semi-formal and office clothes\n" +
            "2. Avoid too much jewelry\n" +
            "3. Avoid eye-beating colors";
        string answer2_3_3_1 = "The best choice for you would be: " + " \n\n" +
            "1. Full-length, formal evening dress\n" +
            "2. Decolletage can be shown\n" +
            "3. Small and elegant evening bags\n" +
            "4. Vintage or Couture jewelry" +
            "What to avoid?" +
            "1. Avoid anything casual, semi-formal and office clothes\n" +
            "2. Avoid too much jewelry\n" +
            "3. Avoid eye-beating colors";
        string answer2_3_3_2 = "The best choice for you would be: " + " \n\n" +
            "1. Full-length, formal evening dress\n" +
            "2. Decolletage can be shown\n" +
            "3. Small and elegant evening bags\n" +
            "4. Vintage or Couture jewelry" +
            "What to avoid?" +
            "1. Avoid anything casual, semi-formal and office clothes\n" +
            "2. Avoid too much jewelry\n" +
            "3. Avoid eye-beating colors";
        string answer2_3_3_3 = "The best choice for you would be: " + " \n\n" +
            "1. Full-length, formal evening dress\n" +
            "2. Decolletage can be shown\n" +
            "3. Small and elegant evening bags\n" +
            "4. Vintage or Couture jewelry" +
            "What to avoid?" +
            "1. Avoid anything casual, semi-formal and office clothes\n" +
            "2. Avoid too much jewelry\n" +
            "3. Avoid eye-beating colors";
        int[] answers;
        string[,,,] variants = new string[,,,]
        {
            {
                {
                    {"So you're a tall, strong man who wants to go on a business formal style meeting.", "So you're a tall, skinny man who wants to go on a business formal style meeting.", "So you're a tall, normal-sized man who wants to go on a business formal style meeting."},
                    {"So you're a not-as-tall, strong man who wants to go on a business formal style meeting.", "So you're a not-as-tall, skinny man who wants to go on a business formal style meeting.", "So you're a not-as-tall, normal-sized man who wants to go on a business formal style meeting."},
                    {"So you're a short, strong man who wants to go on a business formal style meeting.", "So you're a short, skinny man who wants to go on a business formal style meeting.", "So you're a small, normal-sized man who wants to go on a business formal style meeting."}
                },
                {
                    {"So you're a tall, strong man who wants to go on a casual style meeting.", "So you're a tall, skinny man who wants to go on a casual style meeting.", "So you're a tall, normal-sized man who wants to go on a casual style meeting."},
                    {"So you're a not-as-tall, strong man who wants to go on a casual style meeting.", "So you're a not-as-tall, skinny man who wants to go on a casual style meeting.", "So you're a not-as-tall, normal-sized man who wants to go on a casual style meeting."}, // men arr
                    {"So you're a short, strong man who wants to go on a casual style meeting.", "So you're a short, skinny man who wants to go on a casual style meeting.", "So you're a short, normal-ssized man who wants to go on a casual style meeting."}
                },
                {
                    {"So you're a tall, strong man who wants to go on a white tie style meeting(or party).", "So you're a tall, skinny man who wants to go on a white tie style meeting(or party).", "So you're a tall, normal-sized man who wants to go on a white tie style meeting(or party)."},
                    {"So you're a not-as-tall, strong man who wants to go on a white tie style meeting(or party).", "So you're a not-as-tall, skinny man who wants to go on a white tie style meeting(or party).", "So you're a not-as-tall, normal-sized man who wants to go on a white tie style meeting(or party)."}, // men arr
                    {"So you're a short, strong man who wants to go on a white tie style meeting(or party).", "So you're a short, skinny man who wants to go on a white tie style meeting(or party).", "So you're a short, normal-ssized man who wants to go on a white tie style meeting(or party)."}
                }
            },
            {//-
                {
                    {"So you're a tall, strong woman who wants to go on a business formal style meeting.", "So you're a tall, skinny woman who wants to go on a business formal style meeting.", "So you're a tall, normal-sized woman who wants to go on a business formal style meeting."},
                    {"So you're a not-as-tall, strong woman who wants to go on a business formal style meeting.", "So you're a not-as-tall, skinny woman who wants to go on a business formal style meeting.", "So you're a not-as-tall, normal-sized woman who wants to go on a business formal style meeting."},
                    {"So you're a short, strong woman who wants to go on a business formal style meeting.", "So you're a short, skinny woman who wants to go on a business formal style meeting.", "So you're a small, normal-sized woman who wants to go on a business formal style meeting."}
                },
                {
                    {"So you're a tall, strong woman who wants to go on a casual style meeting.", "So you're a tall, skinny woman who wants to go on a casual style meeting.", "So you're a tall, normal-sized woman who wants to go on a casual style meeting."},
                    {"So you're a not-as-tall, strong woman who wants to go on a casual style meeting.", "So you're a not-as-tall, skinny woman who wants to go on a casual style meeting.", "So you're a not-as-tall, normal-sized woman who wants to go on a casual style meeting."}, // men arr
                    {"So you're a short, strong woman who wants to go on a casual style meeting.", "So you're a short, skinny woman who wants to go on a casual style meeting.", "So you're a short, normal-ssized woman who wants to go on a casual style meeting."}
                },
                {
                    {"So you're a tall, strong woman who wants to go on a white tie style meeting(or party).", "So you're a tall, skinny woman who wants to go on a white tie style meeting(or party).", "So you're a tall, normal-sized woman who wants to go on a white tie style meeting(or party)."},
                    {"So you're a not-as-tall, strong woman who wants to go on a white tie style meeting(or party).", "So you're a not-as-tall, skinny woman who wants to go on a white tie style meeting(or party).", "So you're a not-as-tall, normal-sized woman who wants to go on a white tie style meeting(or party)."}, // men arr
                    {"So you're a short, strong woman who wants to go on a white tie style meeting(or party).", "So you're a short, skinny woman who wants to go on a white tie style meeting(or party).", "So you're a short, normal-ssized woman who wants to go on a white tie style meeting(or party)."}
                }
            },
            {// -------------------------------
                {
                    {"So you're a tall, strong human who wants to go on a business formal style meeting.", "So you're a tall, skinny human who wants to go on a business formal style meeting.", "So you're a tall, normal-sized human who wants to go on a business formal style meeting."},
                    {"So you're a not-as-tall, strong human who wants to go on a business formal style meeting.", "So you're a not-as-tall, skinny human who wants to go on a business formal style meeting.", "So you're a not-as-tall, normal-sized human who wants to go on a business formal style meeting."},
                    {"So you're a short, strong human who wants to go on a business formal style meeting.", "So you're a short, skinny human who wants to go on a business formal style meeting.", "So you're a small, normal-sized human who wants to go on a business formal style meeting."}
                },
                {
                    {"So you're a tall, strong human who wants to go on a casual style meeting.", "So you're a tall, skinny human who wants to go on a casual style meeting.", "So you're a tall, normal-sized human who wants to go on a casual style meeting."},
                    {"So you're a not-as-tall, strong human who wants to go on a casual style meeting.", "So you're a not-as-tall, skinny human who wants to go on a casual style meeting.", "So you're a not-as-tall, normal-sized human who wants to go on a casual style meeting."}, // men arr
                    {"So you're a short, strong human who wants to go on a casual style meeting.", "So you're a short, skinny human who wants to go on a casual style meeting.", "So you're a short, normal-ssized human who wants to go on a casual style meeting."}
                },
                {
                    {"So you're a tall, strong human who wants to go on a white tie style meeting(or party).", "So you're a tall, skinny human who wants to go on a white tie style meeting(or party).", "So you're a tall, normal-sized human who wants to go on a white tie style meeting(or party)."},
                    {"So you're a not-as-tall, strong human who wants to go on a white tie style meeting(or party).", "So you're a not-as-tall, skinny human who wants to go on a white tie style meeting(or party).", "So you're a not-as-tall, normal-sized human who wants to go on a white tie style meeting(or party)."}, // men arr
                    {"So you're a short, strong human who wants to go on a white tie style meeting(or party).", "So you're a short, skinny human who wants to go on a white tie style meeting(or party).", "So you're a short, normal-ssized human who wants to go on a white tie style meeting(or party)."}
                }
            }

        };
        public Form1()
        {
            InitializeComponent();
            answers = new int[4];
            label2.Text = "Hello, and welcome." + "\n" +
                "Press \"Forward\" to start";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n--;
            if (n < 0) n = 0;
            show(n);
            if (n == 1)
            {
                radioButton1.Text = "Men";
                radioButton2.Text = "Women";
                // radioButton3.Text = "Private";
            }
            else if (n == 2)
            {
                radioButton1.Text = "Business formal";
                radioButton2.Text = "Casual";
                radioButton3.Text = "White tie";
            }
            else if (n == 3)
            {
                radioButton1.Text = "Tall";
                radioButton2.Text = "Not as tall";
                radioButton3.Text = "short";
            }
            else if (n == 3)
            {
                radioButton1.Text = "Strong";
                radioButton2.Text = "Skinny";
                radioButton3.Text = "Normal";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (n > 0)
                try
                {
                    answers[n - 1] = 1;
                }
                catch (IndexOutOfRangeException) { }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (n > 0)
                try
                {
                    answers[n - 1] = 0;
                }
                catch (IndexOutOfRangeException) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || n == 0)
            {
                n++;
            }
            else
            {
                MessageBox.Show("Choose an option");
            }
            //n++;
            if (n > 6) n = 6;
            show(n);
            if (n == 1)
            {
                radioButton1.Text = "Men";
                radioButton2.Text = "Women";
                // radioButton3.Text = "Private";
            }
            else if (n == 2)
            {
                radioButton1.Text = "Business formal";
                radioButton2.Text = "Casual";
                radioButton3.Text = "White tie";
            }
            else if (n == 3)
            {
                radioButton1.Text = "Tall";
                radioButton2.Text = "Not as tall";
                radioButton3.Text = "Short";
            }
            else if (n == 4)
            {
                radioButton1.Text = "Strong";
                radioButton2.Text = "Skinny";
                radioButton3.Text = "Normal";
            }
            if (n > 0) {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
            }
        }

        public void show(int n)
        {
            switch (n)
            {
                case 1:
                    label2.Text = "What gender are you?";
                    break;
                case 2:
                    label2.Text = "What type of event are you going on?";
                    break;
                case 3:
                    label2.Text = "How tall are you?";
                    break;
                case 4:
                    label2.Text = "What is your body-shape?";
                    break;
                case 5:
                    label2.Text = "Press \"End the test\" button";
                    x = answers[0];
                    y = answers[1];
                    z = answers[2];
                    w = answers[3];
                    break;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (n > 0)
                try
                {
                    answers[n - 1] = 2;
                }
                catch (IndexOutOfRangeException) { }
            if (n == 1)
            {
                radioButton3.Checked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = 1;
            label1.Text = "";
            label2.Text = "What gender are you?";
            radioButton1.Text = "Men";
            radioButton2.Text = "Women";
            radioButton3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            x = y = z = w = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (n < 5)
            {
                MessageBox.Show("Please answer all questions");
            }
            else
            {
                label1.Text = variants[x, y, z, w] + "\n";
                switch (x)
                {
                    // x - 1
                    case 0:
                        switch (y)
                        {
                            case 0:
                                label1.Text += answer1_1;
                                label1.Text += "\n";
                                switch (z)
                                {
                                    case 0:
                                        switch (w)
                                        {
                                            case 0:
                                                label1.Text += answer1_1_1_1;
                                                label1.Text += "\n";
                                                break;
                                            case 1:
                                                label1.Text += answer1_1_1_2;
                                                label1.Text += "\n";
                                                break;
                                            case 2:
                                                label1.Text += answer1_1_1_3;
                                                label1.Text += "\n";
                                                break;
                                        }
                                        break;
                                    case 1:
                                        switch (w)
                                        {
                                            case 0:
                                                label1.Text += answer1_1_2_1;
                                                label1.Text += "\n";
                                                break;
                                            case 1:
                                                label1.Text += answer1_1_2_2;
                                                label1.Text += "\n";
                                                break;
                                            case 2:
                                                label1.Text += answer1_1_2_3;
                                                label1.Text += "\n";
                                                break;
                                        }
                                        break;
                                    case 2:
                                        switch (w)
                                        {
                                            case 0:
                                                label1.Text += answer1_1_3_1;
                                                label1.Text += "\n";
                                                break;
                                            case 1:
                                                label1.Text += answer1_1_3_2;
                                                label1.Text += "\n";
                                                break;
                                            case 2:
                                                label1.Text += answer1_1_3_3;
                                                label1.Text += "\n";
                                                break;
                                        }
                                        break;
                                }
                                break;
                            case 1:
                                label1.Text += answer1_2;
                                label1.Text += "\n";
                                switch (z)
                                {
                                    case 0:
                                        switch (w)
                                        {
                                            case 0:
                                                label1.Text += answer1_2_1_1;
                                                label1.Text += "\n";
                                                break;
                                            case 1:
                                                label1.Text += answer1_2_1_2;
                                                label1.Text += "\n";
                                                break;
                                            case 2:
                                                label1.Text += answer1_2_1_3;
                                                label1.Text += "\n";
                                                break;
                                        }
                                        break;
                                    case 1:
                                        switch (w)
                                        {
                                            case 0:
                                                label1.Text += answer1_2_2_1;
                                                label1.Text += "\n";
                                                break;
                                            case 1:
                                                label1.Text += answer1_2_2_2;
                                                label1.Text += "\n";
                                                break;
                                            case 2:
                                                label1.Text += answer1_2_2_3;
                                                label1.Text += "\n";
                                                break;
                                        }
                                        break;
                                    case 2:
                                        switch (w)
                                        {
                                            case 0:
                                                label1.Text += answer1_2_3_1;
                                                label1.Text += "\n";
                                                break;
                                            case 1:
                                                label1.Text += answer1_2_3_2;
                                                label1.Text += "\n";
                                                break;
                                            case 2:
                                                label1.Text += answer1_2_3_3;
                                                label1.Text += "\n";
                                                break;
                                        }
                                        break;
                                }
                                break;
                            case 2:
                                label1.Text += answer1_3;
                                label1.Text += "\n";
                                switch (z)
                                {
                                    case 0:
                                        switch (w)
                                        {
                                            case 0:
                                                label1.Text += answer1_3_1_1;
                                                label1.Text += "\n";
                                                break;
                                            case 1:
                                                label1.Text += answer1_3_1_2;
                                                label1.Text += "\n";
                                                break;
                                            case 2:
                                                label1.Text += answer1_3_1_3;
                                                label1.Text += "\n";
                                                break;
                                        }
                                        break;
                                    case 1:
                                        switch (w)
                                        {
                                            case 0:
                                                label1.Text += answer1_3_2_1;
                                                label1.Text += "\n";
                                                break;
                                            case 1:
                                                label1.Text += answer1_3_2_2;
                                                label1.Text += "\n";
                                                break;
                                            case 2:
                                                label1.Text += answer1_3_2_3;
                                                label1.Text += "\n";
                                                break;
                                        }
                                        break;
                                    case 2:
                                        switch (w)
                                        {
                                            case 0:
                                                label1.Text += answer1_3_3_1;
                                                label1.Text += "\n";
                                                break;

                                            case 1:
                                                label1.Text += answer1_3_3_2;
                                                label1.Text += "\n";
                                                break;
                                            case 2:
                                                label1.Text += answer1_3_3_3;
                                                label1.Text += "\n";
                                                break;
                                        }
                                        break;
                                }
                                break;
                        }
                        break;
                    case 1:
                        // x - 2
                        switch (y)
                        {
                            case 0:
                                label1.Text += answer2_1;
                                label1.Text += "\n";
                                switch (z)
                                {
                                    case 0:
                                        switch (w)
                                        {
                                            case 0:
                                                label1.Text += answer2_1_1_1;
                                                label1.Text += "\n";
                                                break;
                                            case 1:
                                                label1.Text += answer2_1_1_2;
                                                label1.Text += "\n";
                                                break;
                                            case 2:
                                                label1.Text += answer2_1_1_3;
                                                label1.Text += "\n";
                                                break;
                                        }
                                        break;
                                    case 1:
                                        switch (w)
                                        {
                                            case 0:
                                                label1.Text += answer2_1_2_1;
                                                label1.Text += "\n";
                                                break;
                                            case 1:
                                                label1.Text += answer2_1_2_2;
                                                label1.Text += "\n";
                                                break;
                                            case 2:
                                                label1.Text += answer2_1_2_3;
                                                label1.Text += "\n";
                                                break;
                                        }
                                        break;
                                    case 2:
                                        switch (w)
                                        {
                                            case 0:
                                                label1.Text += answer2_1_3_1;
                                                label1.Text += "\n";
                                                break;
                                            case 1:
                                                label1.Text += answer2_1_3_2;
                                                label1.Text += "\n";
                                                break;
                                            case 2:
                                                label1.Text += answer2_1_3_3;
                                                label1.Text += "\n";
                                                break;
                                        }
                                        break;
                                }
                                break;
                            case 1:
                                label1.Text += answer2_2;
                                label1.Text += "\n";
                                switch (z)
                                {
                                    case 0:
                                        switch (w)
                                        {
                                            case 0:
                                                label1.Text += answer2_2_1_1;
                                                label1.Text += "\n";
                                                break;
                                            case 1:
                                                label1.Text += answer2_2_1_2;
                                                label1.Text += "\n";
                                                break;
                                            case 2:
                                                label1.Text += answer2_2_1_3;
                                                label1.Text += "\n";
                                                break;
                                        }
                                        break;
                                    case 1:
                                        switch (w)
                                        {
                                            case 0:
                                                label1.Text += answer2_2_2_1;
                                                label1.Text += "\n";
                                                break;
                                            case 1:
                                                label1.Text += answer2_2_2_2;
                                                label1.Text += "\n";
                                                break;
                                            case 2:
                                                label1.Text += answer2_2_2_3;
                                                label1.Text += "\n";
                                                break;
                                        }
                                        break;
                                    case 2:
                                        switch (w)
                                        {
                                            case 0:
                                                label1.Text += answer2_2_3_1;
                                                label1.Text += "\n";
                                                break;
                                            case 1:
                                                label1.Text += answer2_2_3_2;
                                                label1.Text += "\n";
                                                break;
                                            case 2:
                                                label1.Text += answer2_2_3_3;
                                                label1.Text += "\n";
                                                break;
                                        }
                                        break;
                                }
                                break;
                            case 2:
                                label1.Text += answer2_3;
                                label1.Text += "\n";
                                switch (z)
                                {
                                    case 0:
                                        switch (w)
                                        {
                                            case 0:
                                                label1.Text += answer2_3_1_1;
                                                label1.Text += "\n";
                                                break;
                                            case 1:
                                                label1.Text += answer2_3_1_2;
                                                label1.Text += "\n";
                                                break;
                                            case 2:
                                                label1.Text += answer2_3_1_3;
                                                label1.Text += "\n";
                                                break;
                                        }
                                        break;
                                    case 1:
                                        switch (w)
                                        {
                                            case 0:
                                                label1.Text += answer2_3_2_1;
                                                label1.Text += "\n";
                                                break;
                                            case 1:
                                                label1.Text += answer2_3_2_2;
                                                label1.Text += "\n";
                                                break;
                                            case 2:
                                                label1.Text += answer2_3_2_3;
                                                label1.Text += "\n";
                                                break;
                                        }
                                        break;
                                    case 2:
                                        switch (w)
                                        {
                                            case 0:
                                                label1.Text += answer2_3_3_1;
                                                label1.Text += "\n";
                                                break;

                                            case 1:
                                                label1.Text += answer2_3_3_2;
                                                label1.Text += "\n";
                                                break;
                                            case 2:
                                                label1.Text += answer2_3_3_3;
                                                label1.Text += "\n";
                                                break;
                                        }
                                        break;
                                }
                                break;
                        }
                        break;
                }
                label2.Text = "Here are results...";
            }
        }
    }
}
