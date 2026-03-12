// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and a free format.
    /// </summary>
    [KnownType(typeof(SystemEventType1Choice.Code))]
    [KnownType(typeof(SystemEventType1Choice.ProprietaryEvent))]
    [JsonDerivedType(typeof(SystemEventType1Choice.Code),nameof(SystemEventType1Choice.Code))]
    [JsonDerivedType(typeof(SystemEventType1Choice.ProprietaryEvent),nameof(SystemEventType1Choice.ProprietaryEvent))]
    [IsoId("_RD_Kkdp-Ed-ak6NoX_4Aeg_544789964")]
    [DisplayName("System Event Type 1 Choice")]
    public abstract partial record SystemEventType1Choice_
    {
    }
}
