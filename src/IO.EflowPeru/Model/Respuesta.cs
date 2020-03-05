using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace IO.EflowPeru.Model
{
    [DataContract]
    public partial class Respuesta :  IEquatable<Respuesta>, IValidatableObject
    {
        public Respuesta(string folio = default(string), decimal? numConsulta = default(decimal?), decimal? ingresoEstimado = default(decimal?))
        {
            this.Folio = folio;
            this.NumConsulta = numConsulta;
            this.IngresoEstimado = ingresoEstimado;
        }
        [DataMember(Name="folio", EmitDefaultValue=false)]
        public string Folio { get; set; }
        [DataMember(Name="numConsulta", EmitDefaultValue=false)]
        public decimal? NumConsulta { get; set; }
        [DataMember(Name="ingresoEstimado", EmitDefaultValue=false)]
        public decimal? IngresoEstimado { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Respuesta {\n");
            sb.Append("  Folio: ").Append(Folio).Append("\n");
            sb.Append("  NumConsulta: ").Append(NumConsulta).Append("\n");
            sb.Append("  IngresoEstimado: ").Append(IngresoEstimado).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Respuesta);
        }
        public bool Equals(Respuesta input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Folio == input.Folio ||
                    (this.Folio != null &&
                    this.Folio.Equals(input.Folio))
                ) && 
                (
                    this.NumConsulta == input.NumConsulta ||
                    (this.NumConsulta != null &&
                    this.NumConsulta.Equals(input.NumConsulta))
                ) && 
                (
                    this.IngresoEstimado == input.IngresoEstimado ||
                    (this.IngresoEstimado != null &&
                    this.IngresoEstimado.Equals(input.IngresoEstimado))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.Folio != null)
                    hashCode = hashCode * 59 + this.Folio.GetHashCode();
                if (this.NumConsulta != null)
                    hashCode = hashCode * 59 + this.NumConsulta.GetHashCode();
                if (this.IngresoEstimado != null)
                    hashCode = hashCode * 59 + this.IngresoEstimado.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
