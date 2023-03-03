class Program
    {
        static void Main(string[] args)
        {
            string name;
            int password, pass1, pass2, pass3, pass4, pass5, pass6; // กำหนดค่าพาสเวิร์ดและเลขแต่ละหลัก
            Console.Write("Your password : ");
            password = int.Parse(Console.ReadLine());
            Console.Write("Your organization name : ");
            name = Console.ReadLine();
            // ใช้หลักการมอดดูโลในการหารเอาเศษของแต่ละหลักโดยหลักหน่วยจะใช้แค่มอดธรรมดา 
            //แต่หลักมากกว่านั้นจะใช้การหาเข้ามาช่วยแทนโดยจะเอาเลขหลักไหนก็จะหารด้วยหลักนั้นเช่นหลักหมื่น ตัวอย่าง 589654 / 10000 = 58.9654 แล้วนำไปมอด 10 จะได้เลข 8 ที่อยู่ในหลักหมื่นมาแทน
            pass1 = password % 10; // หลักหน่วย
            pass2 = ((password / 10) %10); // หลักสิบ
            pass3 = ((password / 100) %10); // หลักร้อย
            pass4 = ((password / 1000) %10); // หลักพัน
            pass5 = ((password / 10000) %10); // หลักหมื่น
            pass6 = ((password / 100000) %10); // หลักแสน

            // โดยจะเช็ค 3 คอนดิชั่นครั้งเดียวกันใน if เดียวโดยใช้ () ในการแยกคอรดิชั่นนึงและใช้ && ในการเชืือมว่าถูกหรือไม่
            if (name == "CIA") //  ใช้ if-else ในการอ่านค่าของชื่อที่รับเข้ามาหละดูว่าตรงกับอันไหน
            {
                if (pass1 % 3 == 0 && (pass2 != 1 && pass2 != 3 && pass2 != 5) && (pass4 >= 6 && pass4 != 8)) // ตามคอนดิชั่นที่หลักหน่วยต้องหาร3ลงตัว , ไม่ใช่ 1 3 และ 5 , และมีค่ามากกว่าเท่ากับ 6 แต่ไม่ใช่ 8 
                {
                    Console.WriteLine("True");
                    Console.WriteLine("CIA password");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else if (name == "FBI")
            {
                if ((pass6 >= 4 && pass6 <= 7) && (pass3 %2 == 0 && pass3 != 6) && (pass5 %2 == 1)) // คอรดิชั่นที่รหัสมากกว่าเท่ากับ 4 แต่น้อยกว่าเท่ากับ 7 , ต้องหาร 2 ลงตัวแต่ไม่ใช่ 6 , ต้องหาร 2 ได้เศษ 1 หรือเลขคี่ 
                {
                    Console.WriteLine("True");
                    Console.WriteLine("FBI password");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else if (name == "NSA")
            {
                if ((pass1 == 1 || pass1 == 2 || pass1 == 3 || pass1 == 5 || pass1 == 6) && // ตัวประกอบของ 30 ได้แก 1 2 3 5 และ 6 
                    (pass3 %3 == 0 && pass3 %2 == 1) && (pass1 ==7 || pass2 ==7 || pass3 ==7 || pass4 ==7 || pass5 ==7 || pass6==7)) // รหัสต้องหาร 3 ลงตัวแต่หาร 2 ไม่ลง ตามจริงมีแค่ 6 แค่ตัวเดียว และ ไล่เช็คแต่หละหลักว่ามีตัวไหนเป็น 7 หรือไหม
                {
                    Console.WriteLine("True");
                    Console.WriteLine("NSA password");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else
            {
                Console.WriteLine("Wrong name");
            }
            
        }
    }