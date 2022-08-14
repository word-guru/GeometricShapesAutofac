using Autofac;
using GeometricShapesAutofac.Repozitorys;
using GeometricShapesAutofac.Repozitorys.Interface;

var builder = new ContainerBuilder();
builder.RegisterType<Repozitory>().As<IRepozitory>();
builder.RegisterType<ShapesRepo>().As<IShapesRepo>();
var container = builder.Build();

using(var scope = container.BeginLifetimeScope())
{
    var shapes = scope.Resolve<IShapesRepo>();

    shapes.Display();
    shapes.Save();
}