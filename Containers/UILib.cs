using Terminal.Gui;

namespace UILib
{
    public class UIWindow : SheetsPlus.ASheet
    {
        public Window WindowInstance { get; private set; }
        public Dictionary<string, SheetsPlus.ASheet> WindowObjects { get; set; } = new Dictionary<string, SheetsPlus.ASheet>();
        public Dictionary<Key, string> KeyBindings { get; set; } = new Dictionary<Key, string>();

        public UIWindow(string title, int width, int height)
        {
            WindowInstance = new Window(title)
            {
                Width = width,
                Height = height
            };
			WindowInstance.KeyPress += (args) => HandleKeyPress(args.KeyEvent);
        }

        public void AddObject(string name, SheetsPlus.ASheet obj)
        {
            if (obj is IWindowObject windowObject)
            {
                WindowObjects[name] = obj;
                WindowInstance.Add(windowObject.GetView());
            }
            else
            {
                throw new Exception("Object does not implement IWindowObject.");
            }
        }

        public void MapKey(Key key, string methodName)
        {
            KeyBindings[key] = methodName;
        }

        public void HandleKeyPress(KeyEvent keyEvent)
		{
			if (KeyBindings.TryGetValue(keyEvent.Key, out string methodName) && methods.ContainsKey(methodName))
			{
				methods[methodName].CALL();
			}
		}
    }

    public interface IWindowObject
    {
        View GetView();
    }

    public class UIPicture : SheetsPlus.ASheet, IWindowObject
    {
        public View GetView()
        {
            // Implementation for picture handling (placeholder for now)
            return new View();
        }
    }

    public class UIButton : SheetsPlus.ASheet, IWindowObject
    {
        public Button ButtonInstance { get; private set; }

        public UIButton(string text, Action onClick)
        {
            ButtonInstance = new Button(text);
            ButtonInstance.Clicked += () => onClick.Invoke();
        }

        public View GetView()
        {
            return ButtonInstance;
        }
    }

    public class UITextBox : SheetsPlus.ASheet, IWindowObject
    {
        public TextField TextFieldInstance { get; set; }
		

        public UITextBox(string initialText)
        {
            TextFieldInstance = new TextField(initialText);
        }

        public View GetView()
        {
            return TextFieldInstance;
        }
    }
	
	
	
	public class UIText : SheetsPlus.ASheet, IWindowObject
    {
        public Label TextFieldInstance { get; set; }
		

        public UIText(string initialText)
        {
            TextFieldInstance = new Label(initialText);
        }

        public View GetView()
        {
            return TextFieldInstance;
        }
    }

    // Add other classes for Slider, Graph, Chart, Selection, Bitmap

    public static class UIHandler
    {
		
		
		/*
		CreateWindow {window Name} {height} {width}
			code inside window
			
		pop
		
		*/
		public static void CloseWindow(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
		{
			
				if (Application.Top != null)
				{

					Application.Top.RemoveAll();
					Application.RequestStop();
				}
				Application.Shutdown();
			
		}
		
		public static void CloseWindowTHIS(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
		{
			
				if (Application.Top != null)
				{
					Application.RequestStop(Application.Top);
					
					Application.Top.RemoveAll();
				}
			
		}
		
		public static void CreateText(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
		{
			string AAtitle = "";
			string AAwidth = "";
			bool t = false;bool w = false; bool h = false;
			for(int i = 1; i<equation.Count(); i++)
			{
				if(equation[i] == "\"" && equation[i+2] == "\"" && D.referenceVar(equation[i+1]) is jumpE_basic.Valued)
				{
					if(!t){
						AAtitle = ((jumpE_basic.Valued)D.referenceVar(equation[i+1])).getV().ToString();
					t = true;}
					else if(!w){
						AAwidth = ((jumpE_basic.Valued)D.referenceVar(equation[i+1])).getV().ToString();
					w = true;}
					i += 2;
				}
				
				
					else if(!t){
						AAtitle = equation[i];
					t = true;}
					else if(!w){
						AAwidth = equation[i];
					w = true;}
				
			}
            var title = AAtitle;
            string initialText = AAwidth;
            var window = new UIText(initialText);
            D.setCustom("UIText", title, window);
		}
		public static void ChangeText(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
		{
			Application.Init();
			if(D is UIText)		{
				if(D.referenceVar(equation[1]) is jumpE_basic.Valued)		{
					((UIText)(D)).TextFieldInstance.Text = (D.referenceVar(equation[1]).ToString());
					Application.Refresh();
				}
			}
		}
		
		
        public static void CreateWindow(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
        {
			string AAtitle = "";
			string AAwidth = "";
			string AAheight = "";
			bool t = false;bool w = false; bool h = false;
			for(int i = 1; i<equation.Count(); i++)
			{
				if(equation[i] == "\"" && equation[i+2] == "\"" && D.referenceVar(equation[i+1]) is jumpE_basic.Valued)
				{
					if(!t){
						AAtitle = ((jumpE_basic.Valued)D.referenceVar(equation[i+1])).getV().ToString();
					t = true;}
					else if(!w){
						AAwidth = ((jumpE_basic.Valued)D.referenceVar(equation[i+1])).getV().ToString();
					w = true;}
					else{
						AAheight = ((jumpE_basic.Valued)D.referenceVar(equation[i+1])).getV().ToString();
					h = true; break;}
					i += 2;
				}
				
				
					else if(!t){
						AAtitle = equation[i];
					t = true;}
					else if(!w){
						AAwidth = equation[i];
					w = true;}
					else{
						AAheight = equation[i];
					h = true; break;}
				
			}
            var title = AAtitle;
            var width = int.Parse(AAwidth);
            var height = int.Parse(AAheight);
            var window = new UIWindow(title, width, height);
            D.setCustom("UIWindow", title, window);
        }
		
		/*
		
		AddObject {UI name} {object name}
		
		
		*/
        public static void AddObjectToWindow(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
        {
			UIWindow window = new UIWindow("Default",100,100);
			string objectName = "";
			SheetsPlus.ASheet objectInstance = new SheetsPlus.ASheet();
			bool w = false;bool o = false;
			for(int i = 1; i<equation.Count(); i++)
			{
				if(equation[i] == "\"" && equation[i+2] == "\"" && D.referenceVar(equation[i+1]) is jumpE_basic.Valued)
				{
					if(!w){
						window = (UIWindow)(D.referenceVar(((jumpE_basic.Valued)(D.referenceVar(equation[i]))).getV().ToString()));
					w = true;}
					else{
						objectInstance = (SheetsPlus.ASheet)(D.referenceVar(((jumpE_basic.Valued)(D.referenceVar(equation[i]))).getV().ToString()));
						objectName = ((jumpE_basic.Valued)(D.referenceVar(equation[i]))).getV().ToString();
					o = true; break;}
					i += 2;
				}
				
				
					else if(!w){
						window = (UIWindow)D.referenceVar(equation[i]);
					w = true;}
					else{
						objectName = equation[i];
						objectInstance = (SheetsPlus.ASheet)D.referenceVar(equation[i]);
					o = true; break;}
				
			}
			
			
            if (window != null && objectInstance != null)
            {
                window.AddObject(objectName, objectInstance);
            }
            else
            {
                throw new Exception("Invalid window or object instance.");
            }
        }

        public static void MapKeyToMethod(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
		{
			var key = (Key)Enum.Parse(typeof(Key), equation[1]);
			var methodName = equation[2];
			var window = (UIWindow)D;
			Console.Write(key + "  " + methodName + "\n");
			if (window != null)
			{
				window.MapKey(key, methodName);
			}
			else
			{
				throw new Exception("Invalid window instance.");
			}
		}


        public static void RunUI(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
        {
            Application.Init();
            foreach (var data in Base.datas)
            {
                if (data is UIWindow window)
                {
                    Application.Top.Add(window.WindowInstance);
                }
            }
			try{
            Application.Run();
			}catch(Exception e){}
        }
		
		public static void RunUITHIS(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
        {
            Application.Init();
            var data = D;
            {
                if (data is UIWindow window)
                {
                    Application.Top.Add(window.WindowInstance);
                }
            }
			try{
            Application.Run();
			}catch(Exception e){}
        }
    }
}
