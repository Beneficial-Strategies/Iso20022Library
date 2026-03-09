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
    /// Provides specification for the underlying product of the margin.
    /// </summary>
    [KnownType(typeof(MarginProductType1Choice.Code))]
    [KnownType(typeof(MarginProductType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MarginProductType1Choice.Code),nameof(MarginProductType1Choice.Code))]
    [JsonDerivedType(typeof(MarginProductType1Choice.Proprietary),nameof(MarginProductType1Choice.Proprietary))]
    #endif
    [IsoId("_Qk_hdNp-Ed-ak6NoX_4Aeg_1848984262")]
    [DisplayName("Margin Product Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MarginProductType1Choice_
    #else
    public abstract partial class MarginProductType1Choice_
    #endif
    {
    }
}
