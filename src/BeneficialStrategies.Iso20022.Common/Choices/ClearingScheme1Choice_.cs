// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Clearing scheme codes related to Registry of the Clearing Positions (RCP).
    /// </summary>
    [KnownType(typeof(ClearingScheme1Choice.Code))]
    [KnownType(typeof(ClearingScheme1Choice.Proprietary))]
    [JsonDerivedType(typeof(ClearingScheme1Choice.Code),nameof(ClearingScheme1Choice.Code))]
    [JsonDerivedType(typeof(ClearingScheme1Choice.Proprietary),nameof(ClearingScheme1Choice.Proprietary))]
    [IsoId("_NDocIAVoEeaubbxOHT6aDQ")]
    [DisplayName("Clearing Scheme 1 Choice")]
    public abstract partial record ClearingScheme1Choice_
    {
    }
}
