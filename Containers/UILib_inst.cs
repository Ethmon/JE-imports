// Register UIWindow and its related commands
jumpE_basic.base_runner.CommandRegistry.add_command( "CreateWindow" , UILib.UIHandler.CreateWindow );
jumpE_basic.base_runner.CommandRegistry.add_command( "AddObject" , UILib.UIHandler.AddObjectToWindow );
jumpE_basic.base_runner.CommandRegistry.add_command( "RunUI" , UILib.UIHandler.RunUI );
jumpE_basic.base_runner.CommandRegistry.add_command( "RunUI-Cur" , UILib.UIHandler.RunUITHIS );
jumpE_basic.base_runner.CommandRegistry.add_command( "Key" , UILib.UIHandler.MapKeyToMethod );
jumpE_basic.base_runner.CommandRegistry.add_command( "StopApp" , UILib.UIHandler.CloseWindow );
jumpE_basic.base_runner.CommandRegistry.add_command( "StopApp-Cur" , UILib.UIHandler.CloseWindowTHIS );
jumpE_basic.base_runner.CommandRegistry.add_command( "CreateText" , UILib.UIHandler.CreateText );
jumpE_basic.base_runner.CommandRegistry.add_command( "TEXT" , UILib.UIHandler.ChangeText );



// Register custom object types
jumpE_basic.Data.add_custtype("UIWindow", typeof(UILib.UIWindow));
jumpE_basic.Data.add_custtype("UIButton", typeof(UILib.UIButton));
jumpE_basic.Data.add_custtype("UITextBox", typeof(UILib.UITextBox));
jumpE_basic.Data.add_custtype("UIText", typeof(UILib.UIText));
jumpE_basic.Data.add_custtype("UIPicture", typeof(UILib.UIPicture));

// Add placeholders for additional UI components as needed
// For example: UISlider, UIGraph, UIChart, UISelection, UIBitmap
