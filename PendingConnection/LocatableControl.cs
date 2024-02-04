using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Shapes;

namespace PendingConnection
{
    // 테스트 코드를 작성 이후 삭제할 예정임.
    public class LocatableControl : TemplatedControl, ILocatable
    {
        // Avalonia 속성으로 Location 정의
        public static readonly StyledProperty<Point> LocationProperty =
            AvaloniaProperty.Register<LocatableControl, Point>(nameof(Location));

        public Point Location
        {
            get => GetValue(LocationProperty);
            set => SetValue(LocationProperty, value);
        }
    
        /*public LocatableControl()
        {
        }*/
    
    }
    
    public class MyRect : Rectangle, ILocatable
    {
        // 테스트로 만듬.
        public static readonly StyledProperty<Point> LocationProperty =
            AvaloniaProperty.Register<MyRect, Point>(nameof(Location));

        public Point Location
        {
            get => GetValue(LocationProperty);
            set => SetValue(LocationProperty, value);
        }
    
    }
}

