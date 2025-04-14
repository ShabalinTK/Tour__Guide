import React from "react";
import "../styles/profile.css";

export default function UserProfile() {
  return (
    <div className="profile-container_tim">
      {/* Sidebar */}
      <aside className="sidebar_tim">
        <div className="card_tim">
          <div className="avatar-wrapper_tim">
            <div className="relative_tim">
              <img
                src="/avatar.jpg"
                alt="User Avatar"
                className="avatar-image_tim"
              />
              <button className="edit-avatar-btn_tim">
                ✏️
              </button>
            </div>
            <h2 className="username_tim">Masum Rana</h2>
            <p className="user-meta_tim">Gothenburg | 15th February</p>
          </div>

          <div className="sidebar-buttons_tim">
            <button>Profile Informations</button>
            <button>Booking History</button>
            <button>Newsletter Subscription</button>
            <button>Manage Notifications</button>
          </div>
        </div>
      </aside>

      {/* Main Content */}
      <section className="main-content_tim">
        <div className="card_tim">
          <h3 className="card-title_tim">Personal Information</h3>
          <div className="form-grid_tim">
            <div className="form-group_tim">
              <label>Name:</label>
              <input type="text" value="Masum Rana" readOnly />
            </div>
            <div className="form-group_tim">
              <label>Date Of Birth</label>
              <div className="input-with-icon_tim">
                <input type="text" value="15/03/1886" readOnly />
                <span className="input-icon_tim">📅</span>
              </div>
            </div>
            <div className="form-group_tim">
              <label>Phone</label>
              <input type="text" value="+46-7644 394 68" readOnly />
            </div>
            <div className="form-group_tim">
              <label>Location</label>
              <input type="text" value="Gothenburg" readOnly />
            </div>
          </div>
          <button className="save-btn_tim">Save</button>
        </div>

        <div className="card_tim">
          <h3 className="card-title_tim">Security</h3>
          <div className="form-grid_tim">
            <div className="form-group_tim">
              <label>Email Address</label>
              <input type="email" value="masumrana15@gmail.com" readOnly />
            </div>
            <div className="form-group_tim">
              <label>Password</label>
              <input type="password" value="**********" readOnly />
            </div>
            <div className="form-group_tim">
              <label>Confirm Password</label>
              <input type="password" value="**********" readOnly />
            </div>
          </div>
          <button className="save-btn_tim">Save</button>
        </div>
      </section>
    </div>
  );
}
