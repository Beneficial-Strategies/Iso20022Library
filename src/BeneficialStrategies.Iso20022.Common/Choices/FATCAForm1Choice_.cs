// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the type of Foreign Account Tax Compliance Act (FATCA) form.
    /// </summary>
    [KnownType(typeof(FATCAForm1Choice.Code))]
    [KnownType(typeof(FATCAForm1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FATCAForm1Choice.Code),nameof(FATCAForm1Choice.Code))]
    [JsonDerivedType(typeof(FATCAForm1Choice.Proprietary),nameof(FATCAForm1Choice.Proprietary))]
    #endif
    [IsoId("_blPakQjLEeS5F6qHcKOrew")]
    [DisplayName("FATCA Form 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FATCAForm1Choice_
    #else
    public abstract partial class FATCAForm1Choice_
    #endif
    {
    }
}
