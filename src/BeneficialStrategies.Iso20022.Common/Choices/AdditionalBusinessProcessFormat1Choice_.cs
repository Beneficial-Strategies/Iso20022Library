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
    /// Choice between a standard code or proprietary code to specify the type of the additional business process.
    /// </summary>
    [KnownType(typeof(AdditionalBusinessProcessFormat1Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AdditionalBusinessProcessFormat1Choice.Code),nameof(AdditionalBusinessProcessFormat1Choice.Code))]
    [JsonDerivedType(typeof(AdditionalBusinessProcessFormat1Choice.Proprietary),nameof(AdditionalBusinessProcessFormat1Choice.Proprietary))]
    #endif
    [IsoId("_Q3dxgNp-Ed-ak6NoX_4Aeg_-250323431")]
    [DisplayName("Additional Business Process Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AdditionalBusinessProcessFormat1Choice_
    #else
    public abstract partial class AdditionalBusinessProcessFormat1Choice_
    #endif
    {
    }
}
