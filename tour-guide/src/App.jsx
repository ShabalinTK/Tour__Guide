import Home from "./pages/Home.jsx";
import {Route, Routes} from "react-router-dom";
import CityListing from "./pages/CityListing.jsx";
import Layout from "./Layout/Layout.jsx";
import CityTour from "./pages/CityTour.jsx"
import ScamPage from "./pages/ScamPage.jsx";
import Profile from "./pages/Profile.jsx";

function App() {
  return (
    <>
      <Routes>
          <Route path="/" element={<Layout />}>
              <Route index element={<Home />} />
              <Route path="/cities" element={<CityListing />} />
              <Route path="/cities/:id" element={<CityTour />} />
              <Route path="/scam" element={<ScamPage />} />
              <Route path="/profile" element={<Profile />} />
          </Route>
      </Routes>
    </>
  );
}

export default App
