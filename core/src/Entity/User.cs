using System;
using System.Collections.Generic;

namespace core.src.Entity {
	public class User:IEquatable<User> {
		string id;
		string uuid;
		string email;
		string password;

		public User ( ) {
		}

		public User ( string id, string uuid, string email, string password ) {
			this.id = id ?? throw new ArgumentNullException (nameof (id));
			this.uuid = uuid ?? throw new ArgumentNullException (nameof (uuid));
			this.email = email ?? throw new ArgumentNullException (nameof (email));
			this.password = password ?? throw new ArgumentNullException (nameof (password));
		}

		public override bool Equals ( object obj ) {
			return Equals (obj as User);
		}

		public bool Equals ( User other ) {
			return other != null &&
				   id == other.id &&
				   uuid == other.uuid &&
				   email == other.email &&
				   password == other.password;
		}

		public override int GetHashCode ( ) {
			int hashCode = -541959895;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode (id);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode (uuid);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode (email);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode (password);
			return hashCode;
		}

		public static bool operator == ( User left, User right ) {
			return EqualityComparer<User>.Default.Equals (left, right);
		}

		public static bool operator != ( User left, User right ) {
			return !(left == right);
		}
	}
}
