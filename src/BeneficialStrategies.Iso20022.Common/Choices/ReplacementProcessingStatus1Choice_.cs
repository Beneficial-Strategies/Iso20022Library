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
    /// Choice of format for the replacement processing status.
    /// </summary>
    [KnownType(typeof(ReplacementProcessingStatus1Choice.Code))]
    [KnownType(typeof(ReplacementProcessingStatus1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReplacementProcessingStatus1Choice.Code),nameof(ReplacementProcessingStatus1Choice.Code))]
    [JsonDerivedType(typeof(ReplacementProcessingStatus1Choice.Proprietary),nameof(ReplacementProcessingStatus1Choice.Proprietary))]
    #endif
    [IsoId("_UXSHUNp-Ed-ak6NoX_4Aeg_-220686671")]
    [DisplayName("Replacement Processing Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReplacementProcessingStatus1Choice_
    #else
    public abstract partial class ReplacementProcessingStatus1Choice_
    #endif
    {
    }
}
