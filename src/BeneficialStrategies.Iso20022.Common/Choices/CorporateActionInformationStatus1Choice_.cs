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
    /// Choice between the different statuses of a corporate action information advice.
    /// </summary>
    [KnownType(typeof(CorporateActionInformationStatus1Choice.ProcessedStatus))]
    [KnownType(typeof(CorporateActionInformationStatus1Choice.RejectedStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionInformationStatus1Choice.ProcessedStatus),nameof(CorporateActionInformationStatus1Choice.ProcessedStatus))]
    [JsonDerivedType(typeof(CorporateActionInformationStatus1Choice.RejectedStatus),nameof(CorporateActionInformationStatus1Choice.RejectedStatus))]
    #endif
    [IsoId("_RiPM0tp-Ed-ak6NoX_4Aeg_-923033281")]
    [DisplayName("Corporate Action Information Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionInformationStatus1Choice_
    #else
    public abstract partial class CorporateActionInformationStatus1Choice_
    #endif
    {
    }
}
