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
    /// Proprietary identification of the reason related to a status.
    /// </summary>
    [KnownType(typeof(ProprietaryReason1Choice.NoSpecifiedReason))]
    [KnownType(typeof(ProprietaryReason1Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProprietaryReason1Choice.NoSpecifiedReason),nameof(ProprietaryReason1Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(ProprietaryReason1Choice.Reason),nameof(ProprietaryReason1Choice.Reason))]
    #endif
    [IsoId("_uoL4YVhFEeOMYfRGLS0NbA")]
    [DisplayName("Proprietary Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProprietaryReason1Choice_
    #else
    public abstract partial class ProprietaryReason1Choice_
    #endif
    {
    }
}
