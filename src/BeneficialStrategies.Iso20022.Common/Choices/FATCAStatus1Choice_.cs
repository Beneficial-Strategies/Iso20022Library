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
    /// Choice of formats for the Foreign Account Tax Compliance Act (FATCA) status.
    /// </summary>
    [KnownType(typeof(FATCAStatus1Choice.Code))]
    [KnownType(typeof(FATCAStatus1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FATCAStatus1Choice.Code),nameof(FATCAStatus1Choice.Code))]
    [JsonDerivedType(typeof(FATCAStatus1Choice.Proprietary),nameof(FATCAStatus1Choice.Proprietary))]
    #endif
    [IsoId("_1dp7UQjREeS5F6qHcKOrew")]
    [DisplayName("FATCA Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FATCAStatus1Choice_
    #else
    public abstract partial class FATCAStatus1Choice_
    #endif
    {
    }
}
