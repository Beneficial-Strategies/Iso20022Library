// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuredCollateral1Choice
{
    /// <summary>
    /// Identifies the collateral when the asset class pledged as collateral does not correspond to an ISIN.
    /// </summary>
    [IsoId("_aPU1wZgAEeSfnc-VXAEapg")]
    [DisplayName("Other Collateral")]
    public partial record OtherCollateral : SecuredCollateral1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies whether the collateral is a pool collateral or not.
        /// </summary>
        [IsoId("_gfxkUN7GEeSaBeqd_btViQ")]
        [DisplayName("Pool Status")]
        [IsoXmlTag("PoolSts")]
        public required CollateralPool1Code PoolStatus { get; init; } 
        
        /// <summary>
        /// Identifies the asset class pledged as collateral, expressed as an ISO 10962 Classification of Financial Instrument (CFI).
        /// </summary>
        [IsoId("_5UkowZf7EeSfnc-VXAEapg")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        [IsoSimpleType(IsoSimpleType.CFIIdentifier)]
        public required IsoCFIIdentifier Type { get; init; } 
        
        /// <summary>
        /// Provides the institutional sector, such as central government, central bank, etc. of the issuer of collateral.
        /// </summary>
        [IsoId("_0ZPaYZf_EeSfnc-VXAEapg")]
        [DisplayName("Sector")]
        [IsoXmlTag("Sctr")]
        [IsoSimpleType(IsoSimpleType.SNA2008SectorIdentifier)]
        public required IsoSNA2008SectorIdentifier Sector { get; init; } 
        
        /// <summary>
        /// Nominal amount of money of the security pledged as collateral, when the collateral cannot be identified through an individual or basket ISIN.
        /// </summary>
        [IsoId("_DWHbp5f7EeSfnc-VXAEapg")]
        [DisplayName("Nominal Amount")]
        [IsoXmlTag("NmnlAmt")]
        public ActiveCurrencyAndAmount? NominalAmount { get; init; } 
        
        
        #nullable disable
        
    }
}
