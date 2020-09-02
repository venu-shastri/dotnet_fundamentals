 class Program
    {
        static void Main(string[] args)
        {
            //Compiler will perform Reflection
            //ImageProcessingLib.ImageProcessor obj = new ImageProcessingLib.ImageProcessor();
            //Console.WriteLine(obj.Process("testContent"));

            try
            {
                Console.WriteLine("Enter Image Processor  Version - Options 1.0.0.0 or 2.0.0.0 ");
                string versionNumber = Console.ReadLine();

                //String Interpollation
                string dllPath = $@"C:\Users\user\source\repos\ImageProcessingLib\ImageProcessingLib\bin\Debug\{versionNumber}\ImageProcessingLib.dll";

                //Load Assembly Dynamically
                System.Reflection.Assembly _dllRef = System.Reflection.Assembly.LoadFile(dllPath);

                //Search For Class by Name ImageProcessor
                System.Type _classRef = _dllRef.GetType("ImageProcessingLib.ImageProcessor");

                //Instantiate Class
                Object obj = System.Activator.CreateInstance(_classRef);

                //Search For Method By Name Process
                System.Reflection.MethodInfo _methodRef = _classRef.GetMethod("Process");

                //Invoke Dynamically
                object result = _methodRef.Invoke(obj, new Object[] { "test Image" });

                Console.WriteLine(result.ToString());
            }
            
            catch (System.IO.FileNotFoundException ex) {

                Console.WriteLine(ex.Message);
            }
            catch(System.Reflection.ReflectionTypeLoadException ex) {

                Console.WriteLine(ex.Message);
            
            }
            catch(NullReferenceException ex) { Console.WriteLine(ex.Message); }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
