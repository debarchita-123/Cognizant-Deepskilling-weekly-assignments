import { useState } from 'react';
import LoginButton from './components/LoginButton';
import LogoutButton from './components/LogoutButton';
import Greeting from './components/Greeting';
import GuestPage from './components/GuestPage';
import UserPage from './components/UserPage';

function App() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  const handleLoginClick = () => {
    setIsLoggedIn(true);
  };

  const handleLogoutClick = () => {
    setIsLoggedIn(false);
  };

  let button;
  let content;

  if (isLoggedIn) {
    button = <LogoutButton onClick={handleLogoutClick} />;
    content = <UserPage />;
  } else {
    button = <LoginButton onClick={handleLoginClick} />;
    content = <GuestPage />;
  }

  return (
  <div style={{ marginLeft: '40px' }}>
    <Greeting isLoggedIn={isLoggedIn} />
    {button}
    {content}
  </div>
);
}

export default App;
