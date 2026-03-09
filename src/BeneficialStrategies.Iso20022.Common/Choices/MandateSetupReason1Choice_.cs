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
    /// Specifies the reason for the setup of the mandate.
    /// </summary>
    [KnownType(typeof(MandateSetupReason1Choice.Code))]
    [KnownType(typeof(MandateSetupReason1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MandateSetupReason1Choice.Code),nameof(MandateSetupReason1Choice.Code))]
    [JsonDerivedType(typeof(MandateSetupReason1Choice.Proprietary),nameof(MandateSetupReason1Choice.Proprietary))]
    #endif
    [IsoId("_iQq8ND2OEeS6DKIV6SF6gw")]
    [DisplayName("Mandate Setup Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MandateSetupReason1Choice_
    #else
    public abstract partial class MandateSetupReason1Choice_
    #endif
    {
    }
}
