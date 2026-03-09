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
    /// Choice of format for the ModificationCancellation information.
    /// </summary>
    [KnownType(typeof(ModificationCancellationAllowed1Choice.Indicator))]
    [KnownType(typeof(ModificationCancellationAllowed1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ModificationCancellationAllowed1Choice.Indicator),nameof(ModificationCancellationAllowed1Choice.Indicator))]
    [JsonDerivedType(typeof(ModificationCancellationAllowed1Choice.Proprietary),nameof(ModificationCancellationAllowed1Choice.Proprietary))]
    #endif
    [IsoId("_Qt7bAtp-Ed-ak6NoX_4Aeg_2048027430")]
    [DisplayName("Modification Cancellation Allowed 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ModificationCancellationAllowed1Choice_
    #else
    public abstract partial class ModificationCancellationAllowed1Choice_
    #endif
    {
    }
}
