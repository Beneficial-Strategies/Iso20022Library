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
    /// Status of the confirmation.
    /// </summary>
    [KnownType(typeof(ConfirmationStatus1Choice.ConfirmationRejected))]
    [KnownType(typeof(ConfirmationStatus1Choice.AmendmentRejected))]
    [KnownType(typeof(ConfirmationStatus1Choice.Status))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ConfirmationStatus1Choice.ConfirmationRejected),nameof(ConfirmationStatus1Choice.ConfirmationRejected))]
    [JsonDerivedType(typeof(ConfirmationStatus1Choice.AmendmentRejected),nameof(ConfirmationStatus1Choice.AmendmentRejected))]
    [JsonDerivedType(typeof(ConfirmationStatus1Choice.Status),nameof(ConfirmationStatus1Choice.Status))]
    #endif
    [IsoId("_wK4rIEhCEea8pJjypp-yMQ")]
    [DisplayName("Confirmation Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ConfirmationStatus1Choice_
    #else
    public abstract partial class ConfirmationStatus1Choice_
    #endif
    {
    }
}
