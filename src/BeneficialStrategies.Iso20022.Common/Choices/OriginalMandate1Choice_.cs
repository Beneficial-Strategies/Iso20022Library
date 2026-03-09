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
    /// Specifies the mandate that is being accepted.
    /// </summary>
    [KnownType(typeof(OriginalMandate1Choice.OriginalMandateIdentification))]
    [KnownType(typeof(OriginalMandate1Choice.OriginalMandate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OriginalMandate1Choice.OriginalMandateIdentification),nameof(OriginalMandate1Choice.OriginalMandateIdentification))]
    [JsonDerivedType(typeof(OriginalMandate1Choice.OriginalMandate),nameof(OriginalMandate1Choice.OriginalMandate))]
    #endif
    [IsoId("_RD1Zk9p-Ed-ak6NoX_4Aeg_1242303022")]
    [DisplayName("Original Mandate 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OriginalMandate1Choice_
    #else
    public abstract partial class OriginalMandate1Choice_
    #endif
    {
    }
}
