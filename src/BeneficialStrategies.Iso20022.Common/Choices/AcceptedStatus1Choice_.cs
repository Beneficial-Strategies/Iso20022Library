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
    /// Choice between a reason or no reason for the corporate action instruction processing accepted status.
    /// </summary>
    [KnownType(typeof(AcceptedStatus1Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcceptedStatus1Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AcceptedStatus1Choice.NoSpecifiedReason),nameof(AcceptedStatus1Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(AcceptedStatus1Choice.Reason),nameof(AcceptedStatus1Choice.Reason))]
    #endif
    [IsoId("_QysmRdp-Ed-ak6NoX_4Aeg_788323528")]
    [DisplayName("Accepted Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AcceptedStatus1Choice_
    #else
    public abstract partial class AcceptedStatus1Choice_
    #endif
    {
    }
}
