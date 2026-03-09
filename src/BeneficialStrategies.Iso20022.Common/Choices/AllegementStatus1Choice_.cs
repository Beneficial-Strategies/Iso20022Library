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
    /// Choice of format for the allegement status.
    /// </summary>
    [KnownType(typeof(AllegementStatus1Choice.Code))]
    [KnownType(typeof(AllegementStatus1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AllegementStatus1Choice.Code),nameof(AllegementStatus1Choice.Code))]
    [JsonDerivedType(typeof(AllegementStatus1Choice.Proprietary),nameof(AllegementStatus1Choice.Proprietary))]
    #endif
    [IsoId("_UakE0dp-Ed-ak6NoX_4Aeg_618404541")]
    [DisplayName("Allegement Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AllegementStatus1Choice_
    #else
    public abstract partial class AllegementStatus1Choice_
    #endif
    {
    }
}
