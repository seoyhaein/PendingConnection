using System;
using System.Diagnostics;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace PendingConnection;

public partial class MainWindow : Window
{
    private PendingConnection _penCon = new PendingConnection();
    public MainWindow()
    {
        InitializeComponent();
        //SetupCanvas();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        var myCanvas = this.FindControl<Canvas>("MyCanvas");
        if (myCanvas != null) 
        {
            _penCon.ShowOrHide(true); 
            _penCon.SourceAnchor = new Point(10, 10); 
            _penCon.TargetAnchor = new Point(100, 100); 
            
            myCanvas.Children.Add(_penCon);
            
            Canvas.SetLeft(_penCon, 10); // 예를 들어 SourceAnchor의 X 좌표가 10이라 가정
            Canvas.SetTop(_penCon, 10);  // 예를 들어 SourceAnchor의 Y 좌표가 10이라 가정
        }
        
    }
    
    private void Size_OnClick(object? sender, RoutedEventArgs e)
    {
        var myCanvas = this.FindControl<TemplateLayoutCanvas>("TemplateCanvas");
        if (myCanvas != null) 
        {
            Debug.WriteLine("test d w/h start");
            Debug.WriteLine(myCanvas.DesiredSize.Width);
            Debug.WriteLine(myCanvas.DesiredSize.Height);
            
            Debug.WriteLine("test w/h start");
            Debug.WriteLine(myCanvas.Width);
            Debug.WriteLine(myCanvas.Height);
        }
        
    }
    
    private void Change_OnClick(object? sender, RoutedEventArgs e)
    {
        var myCanvas = this.FindControl<Canvas>("MyCanvas");
        if (myCanvas != null) 
        {
            //_penCon.ShowOrHide(true); 
            _penCon.SourceAnchor = new Point(100, 100); 
            _penCon.TargetAnchor = new Point(200, 200); 
            
            /*myCanvas.Children.Add(_penCon);
            
            Canvas.SetLeft(_penCon, 10); // 예를 들어 SourceAnchor의 X 좌표가 10이라 가정
            Canvas.SetTop(_penCon, 10);  // 예를 들어 SourceAnchor의 Y 좌표가 10이라 가정*/
        }
        
    }
    
    private void Visible_OnClick(object? sender, RoutedEventArgs e)
    {
        _penCon.ShowOrHide(false);
        
    }
    
    /*private void SetupCanvas()
    {
        var control1 = new LocatableControl(50, 50);
        var control2 = new LocatableControl(150, 100);
        // 예제를 위해 Background 설정 (Avalonia에서는 SolidColorBrush 사용을 가정)
        ControlTemplateCanvas? MyCanvas =  this.FindControl<ControlTemplateCanvas>("TemplateCanvas");
        if (MyCanvas == null) return;
        
        control1.Background = Brushes.Blue;
        control2.Background = Brushes.Red;
        MyCanvas.Children.Add(control1);
        MyCanvas.Children.Add(control2);
    }*/
}