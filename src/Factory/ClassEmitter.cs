// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection.Emit;

namespace BeneficialStrategies.Iso20022.Factory;

/// <summary>Builds, for an interface, a sealed class with a field and a public get/set property for each of its properties.</summary>
internal static class ClassEmitter
{
    private static readonly ModuleBuilder Module = AssemblyBuilder
        .DefineDynamicAssembly(
            new AssemblyName("BeneficialStrategies.Iso20022.Factory.Generated"),
            AssemblyBuilderAccess.Run
        )
        .DefineDynamicModule("Generated");

    private static int _count;

    // Called under the factory's lock: a type is emitted once.
    public static Type Emit(Type iface)
    {
        if (!iface.IsInterface)
            throw new ArgumentException($"'{iface.Name}' is not an interface.", nameof(iface));
        if (!(iface.IsPublic || iface.IsNestedPublic))
            throw new NotSupportedException(
                $"'{iface.FullName}' is not public, so a class made at run time cannot implement it."
            );
        if (
            iface.IsGenericTypeDefinition
            || iface
                .GetInterfaces()
                .Concat([iface])
                .Any(i => i.GetMethods().Any(m => !m.IsSpecialName))
        )
            throw new NotSupportedException(
                $"'{iface.Name}' has methods or is generic; the factory builds classes for the property-only interfaces of the library."
            );

        var interfaces = new[] { iface }.Concat(iface.GetInterfaces()).ToArray();
        var type = Module.DefineType(
            $"Generated.{iface.Name}_{Interlocked.Increment(ref _count)}",
            TypeAttributes.Public | TypeAttributes.Sealed | TypeAttributes.Class,
            typeof(object),
            interfaces
        );

        if (iface.GetCustomAttribute<IsoXmlTagAttribute>() is { } classTag)
            type.SetCustomAttribute(Tag(classTag.XmlTag));

        var fields = new List<FieldBuilder>();
        var lists = new List<(FieldBuilder Field, Type Element)>();
        foreach (var group in interfaces.SelectMany(i => i.GetProperties()).GroupBy(p => p.Name))
        {
            var first = group.First();
            if (group.Any(p => p.PropertyType != first.PropertyType))
                throw new NotSupportedException(
                    $"'{iface.Name}' declares '{first.Name}' with more than one type."
                );

            var field = type.DefineField(
                "_" + first.Name,
                first.PropertyType,
                FieldAttributes.Private
            );
            fields.Add(field);
            if (ElementOf(first.PropertyType) is { } element)
                lists.Add((field, element));

            var property = type.DefineProperty(
                first.Name,
                PropertyAttributes.None,
                first.PropertyType,
                null
            );
            const MethodAttributes accessor =
                MethodAttributes.Public
                | MethodAttributes.Virtual
                | MethodAttributes.Final
                | MethodAttributes.HideBySig
                | MethodAttributes.SpecialName
                | MethodAttributes.NewSlot;

            var get = type.DefineMethod(
                "get_" + first.Name,
                accessor,
                first.PropertyType,
                Type.EmptyTypes
            );
            var il = get.GetILGenerator();
            il.Emit(OpCodes.Ldarg_0);
            il.Emit(OpCodes.Ldfld, field);
            il.Emit(OpCodes.Ret);

            var set = type.DefineMethod("set_" + first.Name, accessor, null, [first.PropertyType]);
            il = set.GetILGenerator();
            il.Emit(OpCodes.Ldarg_0);
            il.Emit(OpCodes.Ldarg_1);
            il.Emit(OpCodes.Stfld, field);
            il.Emit(OpCodes.Ret);

            property.SetGetMethod(get);
            property.SetSetMethod(set);
            foreach (var declared in group)
            {
                if (declared.GetMethod is { } getter)
                    type.DefineMethodOverride(get, getter);
                if (declared.SetMethod is { } setter)
                    type.DefineMethodOverride(set, setter);
            }
            if (first.GetCustomAttribute<IsoXmlTagAttribute>() is { } tag)
                property.SetCustomAttribute(Tag(tag.XmlTag));
        }

        Constructor(type, lists);
        Equals(type, fields);
        Hash(type, fields);
        ToString(type);
        return type.CreateTypeInfo()!.AsType();
    }

    private static Type? ElementOf(Type t) =>
        t.IsGenericType && t.GetGenericTypeDefinition() == typeof(IEnumerable<>)
            ? t.GetGenericArguments()[0]
            : null;

    private static CustomAttributeBuilder Tag(string tag) =>
        new(typeof(IsoXmlTagAttribute).GetConstructor([typeof(string)])!, [tag]);

    // A list starts empty, as it does on a record.
    private static void Constructor(
        TypeBuilder type,
        List<(FieldBuilder Field, Type Element)> lists
    )
    {
        var il = type.DefineConstructor(
                MethodAttributes.Public,
                CallingConventions.Standard,
                Type.EmptyTypes
            )
            .GetILGenerator();
        il.Emit(OpCodes.Ldarg_0);
        il.Emit(OpCodes.Call, typeof(object).GetConstructor(Type.EmptyTypes)!);
        foreach (var (field, element) in lists)
        {
            il.Emit(OpCodes.Ldarg_0);
            il.Emit(
                OpCodes.Newobj,
                typeof(ValueList<>).MakeGenericType(element).GetConstructor(Type.EmptyTypes)!
            );
            il.Emit(OpCodes.Stfld, field);
        }
        il.Emit(OpCodes.Ret);
    }

    private static void LoadBoxed(ILGenerator il, FieldBuilder field)
    {
        il.Emit(OpCodes.Ldfld, field);
        if (field.FieldType.IsValueType)
            il.Emit(OpCodes.Box, field.FieldType);
    }

    private static void Equals(TypeBuilder type, List<FieldBuilder> fields)
    {
        var method = type.DefineMethod(
            "Equals",
            MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.HideBySig,
            typeof(bool),
            [typeof(object)]
        );
        var il = method.GetILGenerator();
        var other = il.DeclareLocal(type);
        var no = il.DefineLabel();
        il.Emit(OpCodes.Ldarg_1);
        il.Emit(OpCodes.Isinst, type);
        il.Emit(OpCodes.Stloc, other);
        il.Emit(OpCodes.Ldloc, other);
        il.Emit(OpCodes.Brfalse, no);
        foreach (var field in fields)
        {
            il.Emit(OpCodes.Ldarg_0);
            LoadBoxed(il, field);
            il.Emit(OpCodes.Ldloc, other);
            LoadBoxed(il, field);
            il.Emit(
                OpCodes.Call,
                typeof(object).GetMethod(nameof(Equals), [typeof(object), typeof(object)])!
            );
            il.Emit(OpCodes.Brfalse, no);
        }
        il.Emit(OpCodes.Ldc_I4_1);
        il.Emit(OpCodes.Ret);
        il.MarkLabel(no);
        il.Emit(OpCodes.Ldc_I4_0);
        il.Emit(OpCodes.Ret);
        type.DefineMethodOverride(
            method,
            typeof(object).GetMethod(nameof(Equals), [typeof(object)])!
        );
    }

    private static void Hash(TypeBuilder type, List<FieldBuilder> fields)
    {
        var method = type.DefineMethod(
            "GetHashCode",
            MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.HideBySig,
            typeof(int),
            Type.EmptyTypes
        );
        var il = method.GetILGenerator();
        il.Emit(OpCodes.Ldc_I4, 17);
        foreach (var field in fields)
        {
            il.Emit(OpCodes.Ldarg_0);
            LoadBoxed(il, field);
            il.Emit(
                OpCodes.Call,
                typeof(GeneratedValueSemantics).GetMethod(nameof(GeneratedValueSemantics.Combine))!
            );
        }
        il.Emit(OpCodes.Ret);
        type.DefineMethodOverride(method, typeof(object).GetMethod(nameof(GetHashCode))!);
    }

    private static void ToString(TypeBuilder type)
    {
        var method = type.DefineMethod(
            "ToString",
            MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.HideBySig,
            typeof(string),
            Type.EmptyTypes
        );
        var il = method.GetILGenerator();
        il.Emit(OpCodes.Ldarg_0);
        il.Emit(
            OpCodes.Call,
            typeof(GeneratedValueSemantics).GetMethod(nameof(GeneratedValueSemantics.Describe))!
        );
        il.Emit(OpCodes.Ret);
        type.DefineMethodOverride(method, typeof(object).GetMethod(nameof(ToString))!);
    }
}
