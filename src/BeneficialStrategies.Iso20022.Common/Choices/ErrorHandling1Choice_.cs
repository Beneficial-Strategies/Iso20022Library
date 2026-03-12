// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the choice between the listed and the proprietary error codes.
    /// </summary>
    [KnownType(typeof(ErrorHandling1Choice.Code))]
    [KnownType(typeof(ErrorHandling1Choice.Proprietary))]
    [JsonDerivedType(typeof(ErrorHandling1Choice.Code),nameof(ErrorHandling1Choice.Code))]
    [JsonDerivedType(typeof(ErrorHandling1Choice.Proprietary),nameof(ErrorHandling1Choice.Proprietary))]
    [IsoId("_RZI7Mdp-Ed-ak6NoX_4Aeg_-632950582")]
    [DisplayName("Error Handling 1 Choice")]
    public abstract partial record ErrorHandling1Choice_
    {
    }
}
