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
    /// Choice of format for the Pending Processing status.
    /// </summary>
    [KnownType(typeof(PendingProcessing1Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingProcessing1Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingProcessing1Choice.NoSpecifiedReason),nameof(PendingProcessing1Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingProcessing1Choice.Reason),nameof(PendingProcessing1Choice.Reason))]
    #endif
    [IsoId("_Azyp4NokEeC60axPepSq7g_-1440750655")]
    [DisplayName("Pending Processing 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingProcessing1Choice_
    #else
    public abstract partial class PendingProcessing1Choice_
    #endif
    {
    }
}
